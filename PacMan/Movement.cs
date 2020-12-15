using System;

namespace PacMan
{
    class Movement
    {
        public void MovePacMan(string[,] map)
        {
            Detection detection = new Detection();
            Player player = new Player();
            ConsoleKey key = ConsoleKey.LeftArrow;

            while (true)
            {
                Console.SetCursorPosition(player.PositionX, player.PositionY);
                Console.WriteLine(" ");

                if (key == ConsoleKey.UpArrow)
                {
                    ModifyPosition(map, 0, -1, player);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    ModifyPosition(map, 1, 0, player);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    ModifyPosition(map, 0, 1, player);
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    ModifyPosition(map, -1, 0, player);
                }

                Console.SetCursorPosition(player.PositionX, player.PositionY);
                Console.WriteLine("C");

                DateTime beginWait = DateTime.Now;
                double speed = 0.3;
                while (!Console.KeyAvailable && DateTime.Now.Subtract(beginWait).TotalSeconds < speed) { }

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                }
            }
        }
        private void ModifyPosition(string[,] map, int x, int y, Player player)
        {
            x = player.PositionX + x;
            y = player.PositionY + y;

            if (map[y, x - 43] != "#")
            {
                player.PositionX = x;
                player.PositionY = y;
            }
        }
    }
}
