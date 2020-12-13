using System;

namespace PacMan
{
    class Movement
    {
        public void MovePacMan()
        {
            int x = 60;
            int y = 12;
            ConsoleKey key = ConsoleKey.LeftArrow;

            while (true)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    y--;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("C");

                }
                else if (key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    x++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("C");
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("C");
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    x--;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("C");
                }

                DateTime beginWait = DateTime.Now;
                double speed = 0.3;
                while (!Console.KeyAvailable && DateTime.Now.Subtract(beginWait).TotalSeconds < speed) { }

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                }
            }
        }
    }
}
