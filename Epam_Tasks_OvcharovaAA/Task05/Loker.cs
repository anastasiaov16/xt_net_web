using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Task05
{
    class Loker
    {
        FileSystemWatcher watcher;
        bool enabled = true;
        string source;
        string copy;

        public Loker(string Source, string Copy)
        {
            source = Source;
            copy = Copy;
        }

        public void Start()
        {
            using (watcher = new FileSystemWatcher(source, "*.txt*"))
            {
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName
                                   | NotifyFilters.DirectoryName
                                   | NotifyFilters.CreationTime;

                watcher.IncludeSubdirectories = true;

                watcher.Deleted += OnHandler;
                watcher.Created += OnHandler;
                watcher.Changed += OnHandler;
                watcher.Renamed += OnHandler;

                watcher.EnableRaisingEvents = true;

                while (enabled)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void OnHandler(object sender, FileSystemEventArgs e)
        {
            DateTime date = DateTime.Now;

            //string logs = copy + date.Date + date.TimeOfDay;

            string logs = copy + date.Day + "."
                    + date.Month + "." + date.Year + "_" + date.Hour + "h"
                    + date.Minute + "m" + date.Second + "s";

            DirectoryCopy(source, logs, true);
        }

        public static void DirectoryCopy(string source, string copy, bool check)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
            }

            if (!Directory.Exists(copy))
            {
                Directory.CreateDirectory(copy);
            }

            foreach (FileInfo fi in dir.GetFiles("*.txt"))
            {
                string tempPath = Path.Combine(copy, fi.Name);
                fi.CopyTo(tempPath, true);
            }

            if (check)
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    string temppath = Path.Combine(copy, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, check);
                }
            }
        }

        public static void BackUpSystem(int input, string sourceDirectory, string copy)
        {
            if (input == 1)
            {
                DateTime date = DateTime.Now;

                //string logs = copy + date.Date + date.TimeOfDay;

                string logFolder = copy + date.Day + "."
                    + date.Month + "." + date.Year + "_" + date.Hour + "h"
                    + date.Minute + "m" + date.Second + "s";

                Loker Loker = new Loker(sourceDirectory, copy);
                Loker.Start();
            }
            else if (input == 2)
            {
                Console.WriteLine("Enter the time for which you whant to back up");
                Console.WriteLine("Format: day.month.year + _ + hours + h + minutes + m + seconds + s");

                string[] txtList = Directory.GetFiles(sourceDirectory, "*.txt");
                var tmp = Console.ReadLine();
                DirectoryInfo copyDir = new DirectoryInfo(copy + tmp);

                if (copyDir.Exists)
                {
                    try
                    {
                        foreach (var item in txtList)
                        {
                            File.Delete(item);
                        }
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    DirectoryInfo sourceDir = new DirectoryInfo(sourceDirectory);
                    foreach (DirectoryInfo dir in sourceDir.GetDirectories())
                    {
                        try
                        {
                            dir.Delete(true);
                        }
                        catch (IOException e)
                        {
                           throw new Exception(e.Message);
                        }
                    }

                    DirectoryCopy(copyDir.ToString(), sourceDirectory, true);
                    Console.WriteLine("Backup completed successfully");
                }
                else
                {
                    Console.WriteLine("Can't back up for this time :(");
                }
            }
        }

        public static void StartTask()
        {
            Console.WriteLine("Task 05");
            Console.WriteLine("Select the mode:");
            Console.WriteLine("1. Observer.");
            Console.WriteLine("2. Backup.");

            int switcher;
            while (!(int.TryParse(Console.ReadLine(), out switcher) && (switcher == 1 || switcher == 2)))
            {
                Console.WriteLine("Enter the correct value");
            }
            BackUpSystem(switcher, @"C:\Users\Александр\Documents\ООП\change", @"C:\Users\Александр\Documents\ООП\logs\");
        }
    }
}

