using System;

namespace PacMan
{
    class Movement
    {
        public void MovePacMan(string[,] map)
        {
            Detection detection = new Detection();
            Player player = new Player();
            Coordinate coordinate = new Coordinate();
            Display display = new Display();
            ConsoleKey key = ConsoleKey.UpArrow;
            int score = 0;

            while (true)
            {
                coordinate.X = 0;
                coordinate.Y = 0;
                Console.SetCursorPosition(player.PositionX, player.PositionY);
                Console.WriteLine(" ");

                if (key == ConsoleKey.UpArrow)
                {
                    coordinate.Y = -1;
                    ModifyPosition(coordinate, player);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    coordinate.X = 1;
                    ModifyPosition(coordinate, player);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    coordinate.Y = 1;
                    ModifyPosition(coordinate, player);
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    coordinate.X = -1;
                    ModifyPosition(coordinate, player);
                }

                string mapSymbol = map[coordinate.Y, coordinate.X - 43];
                detection.TryDetectWallHit(mapSymbol, player, coordinate);

                if (detection.TryDetectFeedHit(mapSymbol, ref score))
                {
                    map[player.PositionY, player.PositionX - 43] = " ";
                }

                display.DisplayScore(score);

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
        private void ModifyPosition(Coordinate coordinate, Player player)
        {
            coordinate.X = player.PositionX + coordinate.X;
            coordinate.Y = player.PositionY + coordinate.Y;
        }
    }
}
