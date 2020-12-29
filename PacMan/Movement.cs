using System;
using System.Collections.Generic;

namespace PacMan
{
    class Movement
    {
        public void MovePlayer(string[,] map)
        {
            Detection detection = new Detection();
            Player player = new Player(3);
            Coordinate coordinate = new Coordinate();
            Display display = new Display();
            Monster monster = new Monster();

            List<Monster> MonsterList = monster.MonsterList();
            ConsoleKey key = ConsoleKey.LeftArrow;
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
                    ModifyPlayerPosition(coordinate, player);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    coordinate.X = 1;
                    ModifyPlayerPosition(coordinate, player);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    coordinate.Y = 1;
                    ModifyPlayerPosition(coordinate, player);
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    coordinate.X = -1;
                    ModifyPlayerPosition(coordinate, player);
                }

                string mapSymbol = map[coordinate.Y, coordinate.X - 43];
                detection.TryDetectWallHit(mapSymbol, player, coordinate);

                //monster movement
                MoveMonster(map, ref MonsterList);
                detection.TryDetectMonsterHit(mapSymbol, ref player);

                if (detection.TryDetectFeedHit(mapSymbol, ref score))
                {
                    map[player.PositionY, player.PositionX - 43] = " ";
                }

                display.DisplayPlayer(player);
                display.DisplayStats(score, player);
                DateTime beginWait = DateTime.Now;
                double speed = 0.3;

                while (!Console.KeyAvailable && DateTime.Now.Subtract(beginWait).TotalSeconds < speed) { }

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                }
            }
        }
        private void MoveMonster(string[,] map, ref List<Monster> monsterList)
        {
            //Move monster1
            //Remove old monster position
            Console.SetCursorPosition(monsterList[0].PositionX, monsterList[0].PositionY);
            Console.WriteLine(" ");
            map[monsterList[0].PositionY, monsterList[0].PositionX - 43] = " ";

            Random rnd = new Random();
            Coordinate coordinate;
            string mapSymbol;

            do
            {
                coordinate = new Coordinate();
                int directionIndex = rnd.Next(1, 5);

                if (directionIndex == 1)
                {
                    coordinate.Y = -1;
                    ModifyMonsterPosition(coordinate, monsterList[0]);
                }
                else if (directionIndex == 2)
                {
                    coordinate.X = 1;
                    ModifyMonsterPosition(coordinate, monsterList[0]);
                }
                else if (directionIndex == 3)
                {
                    coordinate.Y = 1;
                    ModifyMonsterPosition(coordinate, monsterList[0]);
                }
                else if (directionIndex == 4)
                {
                    coordinate.X = -1;
                    ModifyMonsterPosition(coordinate, monsterList[0]);
                }

                mapSymbol = map[coordinate.Y, coordinate.X - 43];

            } while (mapSymbol == "#");

            monsterList[0].PositionX = coordinate.X;
            monsterList[0].PositionY = coordinate.Y;
            //Add new monster position
            Console.SetCursorPosition(monsterList[0].PositionX, monsterList[0].PositionY);
            Console.WriteLine("M");
            map[monsterList[0].PositionY, monsterList[0].PositionX - 43] = "M";
            //
        }
        private void ModifyPlayerPosition(Coordinate coordinate, Player player)
        {
            coordinate.X = player.PositionX + coordinate.X;
            coordinate.Y = player.PositionY + coordinate.Y;
        }
        private void ModifyMonsterPosition(Coordinate coordinate, Monster monster)
        {
            coordinate.X = monster.PositionX + coordinate.X;
            coordinate.Y = monster.PositionY + coordinate.Y;
        }
    }
}
