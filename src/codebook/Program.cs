using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodebookMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaptersPath = Path.Combine(Directory.GetCurrentDirectory(), "../chapters");

            int selectedGroupIndex = 0;
            while (true)
            {
                var chapters = Directory.GetDirectories(chaptersPath)
                    .Select(dir => new
                    {
                        Name = Path.GetFileName(dir),
                        Path = dir
                    })
                    .OrderBy(chapter => chapter.Name)
                    .ToArray();

                var groupedChapters = chapters
                    .GroupBy(chapter => Regex.Match(chapter.Name, @"^\d+_(\w+)").Groups[1].Value)
                    .OrderBy(group => group.Min(chapter => chapter.Name))
                    .ToArray();

                Console.Clear();
                Console.WriteLine("Welcome to the C# Codebook");
                Console.WriteLine("Use Up/Down Arrow keys to navigate and Enter to select.\n");

                selectedGroupIndex = DisplayMenu("Select a group:", groupedChapters.Select(g => g.Key).Concat(new[] { "Exit" }).ToArray(), selectedGroupIndex);

                if (selectedGroupIndex == groupedChapters.Length)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else if (selectedGroupIndex == -1)
                {
                    continue;
                }

                var selectedGroup = groupedChapters[selectedGroupIndex].OrderBy(chapter => chapter.Name).ToArray();
                int selectedChapterIndex = 0;
                selectedChapterIndex = DisplayMenu($"Select a chapter from {groupedChapters[selectedGroupIndex].Key}:", selectedGroup.Select(c => c.Name).Concat(new[] { "Back" }).ToArray(), selectedChapterIndex);

                if (selectedChapterIndex == selectedGroup.Length)
                {
                    continue;
                }
                else if (selectedChapterIndex == -1)
                {
                    continue;
                }

                RunChapter(selectedGroup[selectedChapterIndex].Path);
            }
        }

        static int DisplayMenu(string prompt, string[] options, int selectedIndex = 0)
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine(prompt);
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}");
                    }
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;
                }
                else if (key == ConsoleKey.Enter)
                {
                    return selectedIndex;
                }
            } while (true);
        }

        static void RunChapter(string chapterPath)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Running chapter: {Path.GetFileName(chapterPath)}\n");

                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "dotnet",
                        Arguments = $"run --project \"{chapterPath}\"",
                        UseShellExecute = true,
                        CreateNoWindow = true,
                    }
                };

                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }

                process.WaitForExit();

                Console.WriteLine("\nChapter process has exited. Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }

        static void AddChapter(string chaptersPath)
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the new chapter:"); 
            string name = Console.ReadLine();

            Console.WriteLine("Should the chapter be added at the end? (y/n):");
            bool atEnd = Console.ReadKey().Key == ConsoleKey.Y;

            var chapters = Directory.GetDirectories(chaptersPath).OrderBy(d => d).ToList();
            var newChapterNumber = atEnd ? chapters.Count + 1 : 1;
            var newChapterName = $"{newChapterNumber:D2}_{name}";
            var newChapterPath = Path.Combine(chaptersPath, newChapterName);

            Process.Start("dotnet", $"new console -o \"{newChapterPath}\" --name \"{name}\"").WaitForExit();

            if (!atEnd)
            {
                for (int i = newChapterNumber; i <= chapters.Count; i++)
                {
                    var oldPath = chapters[i - 1];
                    var newPath = Path.Combine(chaptersPath, $"{i + 1:D2}_{Path.GetFileName(oldPath).Substring(3)}");
                    Directory.Move(oldPath, newPath);
                }
            }

            // Add the new project to the solution
            var solutionPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../codebook-csharp.sln"));
            var projectPath = Path.GetFullPath(Path.Combine(newChapterPath, $"{name}.csproj"));

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"sln \"{solutionPath}\" add \"{projectPath}\"",
                WorkingDirectory = Path.GetDirectoryName(solutionPath),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                Console.WriteLine(process.StandardError.ReadToEnd());
            }

            Console.WriteLine($"Chapter {newChapterName} added. Press any key to continue...");
            Console.ReadKey();
        }

        static void RemoveChapter(string chaptersPath, int index)
        {
            var chapters = Directory.GetDirectories(chaptersPath).OrderBy(d => d).ToList();
            var chapterPath = chapters[index];
            var projectName = Path.GetFileName(chapterPath).Substring(3); // Remove the numbering
            var projectPath = Path.Combine(chapterPath, $"{projectName}.csproj");

            // Remove the project from the solution
            var solutionPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../codebook-csharp.sln"));

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"sln \"{solutionPath}\" remove \"{projectPath}\"",
                WorkingDirectory = Path.GetDirectoryName(solutionPath),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                Console.WriteLine(process.StandardError.ReadToEnd());
            }

            // Delete the chapter directory
            Directory.Delete(chapterPath, true);

            // Rename remaining chapters
            for (int i = index; i < chapters.Count - 1; i++)
            {
                var oldPath = chapters[i + 1];
                var newPath = Path.Combine(chaptersPath, $"{i + 1:D2}_{Path.GetFileName(oldPath).Substring(3)}");
                Directory.Move(oldPath, newPath);
            }

            Console.WriteLine($"Chapter {index + 1:D2} removed. Press any key to continue...");
            Console.ReadKey();
        }
    }
}