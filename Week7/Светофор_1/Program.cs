using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Светофор_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Timer timer = new Timer(TurnOn, null, 0, 600);
            Console.ReadKey();
        }

        public static int level = 1;
        static void TurnOn(object state)
        {
            Console.Clear();
            string name = string.Format("Colors/{0}.txt", level);
            Background();
            switch (level)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            level++;
            if (level > 3)
                level = 1;

            using (StreamReader reader = new StreamReader(name))

            {
                int r = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int c = 0; c < line.Length; ++c)
                    {
                        if (line[c] == 'o')
                        {
                            Console.SetCursorPosition(c, r);
                            Console.Write("o");
                        }
                    }
                    r++;
                }
            }


        }
        public static void Background()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string name = string.Format("Colors/{0}.txt", level);
            using (StreamReader reader = new StreamReader(name))

            {
                int r = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int c = 0; c < line.Length; ++c)
                    {
                        if (line[c] != 'o')
                        {
                            Console.SetCursorPosition(c, r);
                            Console.Write(line[c]);
                        }
                    }
                    r++;
                }
            }
        }
    }
}
