using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Layer
{
    public FileSystemInfo[] Content
    {
        get;
        set;
    }

    public int SelectedItem
    {
        get;
        set;
    }

    public void Print()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        for (int i = 0; i < Content.Length; i++)
        {
            if (i == SelectedItem)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(Content[i].Name);
        }
    }
}

namespace Task
{
    class Program
    {
        //create an enumeration, which consists files and directories
        enum ViewMode
        {
            Directory,
            File
        }

        static void Main(string[] args)
        {
            //open the directory
            DirectoryInfo folder = new DirectoryInfo(@"D:\Phrases");
            Stack<Layer> history = new Stack<Layer>();
            //add new layer in stack, which contains the information of selected directory
            history.Push(
                new Layer
                {
                    Content = folder.GetFileSystemInfos()
                }
            );
            
            ViewMode viewMode = ViewMode.Directory;
            bool esc = false;
            while (!esc)
            {
                if (viewMode == ViewMode.Directory)
                {
                    history.Peek().Print();
                }
                //“read” which key we pressed and set the properties for each key
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--;
                        break;

                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;
                        break;

                    case ConsoleKey.Enter: //open file or directory
                        int x = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            viewMode = ViewMode.Directory;
                            DirectoryInfo selectedDir = fileSystemInfo as DirectoryInfo;
                            history.Push(new Layer { Content = selectedDir.GetFileSystemInfos() });
                        }
                        else
                        {
                            viewMode = ViewMode.File;
                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (viewMode == ViewMode.Directory)
                        {
                            history.Pop();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            viewMode = ViewMode.Directory;
                        }
                        break;

                    case ConsoleKey.Delete: //delete file or directory
                        int x2 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];
                        history.Peek().SelectedItem--;
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo2 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo2.FullName, true);
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                            File.Delete(fileSystemInfo2.FullName);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }
                        break;

                    case ConsoleKey.F2: //rename file or direcory
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("New name: ");
                        string name = Console.ReadLine();
                        int x3 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo3 = history.Peek().Content[x3];
                        if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo3 as DirectoryInfo;
                            Directory.Move(fileSystemInfo3.FullName, directoryInfo.Parent + "/" + name);
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo3 as FileInfo;
                            File.Move(fileSystemInfo3.FullName, fileInfo.Directory.FullName + "/" + name);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }
                        break;

                    case ConsoleKey.Escape:
                        esc = true;
                        break;
                }

            }

        }
    }
}
