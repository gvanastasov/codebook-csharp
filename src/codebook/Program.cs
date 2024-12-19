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

                Console.Clear();
                Console.WriteLine("Welcome to the C# Codebook");
                Console.WriteLine("Use Up/Down Arrow keys to navigate and Enter to select.\n");

                int selectedIndex = DisplayMenu(chaptersPath, chapters);

                if (selectedIndex == chapters.Length)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else if (selectedIndex == -1)
                {
                    continue;
                }

                RunChapter(chapters[selectedIndex].Path);
            }
        }

        static int DisplayMenu(string chaptersPath, dynamic[] chapters)
        {
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select a chapter:\n");

                for (int i = 0; i < chapters.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {chapters[i].Name}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {chapters[i].Name}");
                    }
                }

                Console.WriteLine("\nUse Up/Down Arrow keys to navigate and Enter to select.");
                Console.WriteLine("Press A to add, R to remove.");

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex == 0) ? chapters.Length - 1 : selectedIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex == chapters.Length - 1) ? 0 : selectedIndex + 1;
                        break;
                    case ConsoleKey.Enter:
                        return selectedIndex;
                    case ConsoleKey.A:
                        AddChapter(chaptersPath);
                        return -1;
                    case ConsoleKey.R:
                        RemoveChapter(chaptersPath, selectedIndex);
                        return -1;
                }
            }
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