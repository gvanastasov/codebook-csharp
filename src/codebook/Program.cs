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
                var groups = Directory.GetDirectories(chaptersPath)
                    .Select(dir => new
                    {
                        Name = Path.GetFileName(dir),
                        Path = dir
                    })
                    .OrderBy(group => group.Name)
                    .ToArray();

                Console.Clear();
                Console.WriteLine("Welcome to the C# Codebook");
                Console.WriteLine("Use Up/Down Arrow keys to navigate and Enter to select.\n");

                selectedGroupIndex = DisplayMenu("Select a group:", groups.Select(g => g.Name).Concat(new[] { "Exit" }).ToArray(), selectedGroupIndex);

                if (selectedGroupIndex == groups.Length)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else if (selectedGroupIndex == -1)
                {
                    continue;
                }

                var selectedGroup = groups[selectedGroupIndex];
                var chapters = Directory.GetDirectories(selectedGroup.Path)
                    .Select(dir => new
                    {
                        Name = Path.GetFileName(dir),
                        Path = dir
                    })
                    .OrderBy(chapter => chapter.Name)
                    .ToArray();

                int selectedChapterIndex = 0;
                selectedChapterIndex = DisplayMenu($"Select a chapter from {selectedGroup.Name}:", chapters.Select(c => c.Name).Concat(new[] { "Add Chapter", "Remove Chapter", "Back" }).ToArray(), selectedChapterIndex);

                if (selectedChapterIndex == chapters.Length)
                {
                    AddChapter(selectedGroup.Path);
                    continue;
                }
                else if (selectedChapterIndex == chapters.Length + 1)
                {
                    RemoveChapter(selectedGroup.Path);
                    continue;
                }
                else if (selectedChapterIndex == chapters.Length + 2)
                {
                    continue;
                }
                else if (selectedChapterIndex == -1)
                {
                    continue;
                }

                RunChapter(chapters[selectedChapterIndex].Path);
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
                else if (key == ConsoleKey.A)
                {
                    return options.Length; // Special case for adding a chapter
                }
                else if (key == ConsoleKey.R)
                {
                    return options.Length + 1; // Special case for removing a chapter
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

       static void RemoveChapter(string categoryPath)
        {
            Console.Clear();
            Console.WriteLine("Remove a chapter");

            var chapters = Directory.GetDirectories(categoryPath)
                .Select(dir => new
                {
                    Name = Path.GetFileName(dir),
                    Path = dir
                })
                .OrderBy(chapter => chapter.Name)
                .ToArray();

            int selectedChapterIndex = DisplayMenu("Select a chapter to remove:", chapters.Select(c => c.Name).Concat(new[] { "Cancel" }).ToArray());

            if (selectedChapterIndex == chapters.Length)
            {
                return;
            }
            else if (selectedChapterIndex == -1)
            {
                return;
            }

            var selectedChapter = chapters[selectedChapterIndex];
            Directory.Delete(selectedChapter.Path, true);

            // Remove the project from the solution
            string solutionFilePath = Path.Combine(Directory.GetParent(categoryPath).Parent.FullName, "../codebook-csharp.sln");
            Process.Start("dotnet", $"sln \"{solutionFilePath}\" remove \"{Path.Combine(selectedChapter.Path, $"{Path.GetFileName(selectedChapter.Path)}.csproj")}\"").WaitForExit();

            Console.WriteLine($"Chapter '{selectedChapter.Name}' removed from category '{Path.GetFileName(categoryPath)}'.");

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}