using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PacMan
{
    class Display
    {
        public void DisplayStats(int score, Player player)
        {
            Console.SetCursorPosition(43, 15);
            Console.WriteLine($"Lives: {player.Life}");
            Console.SetCursorPosition(68, 15);
            Console.WriteLine($"Score: {score}");
        }
        public void DisplayReady(Player player)
        {
            DisplayPlayer(player);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(56, 6);
            Console.WriteLine("Ready..");
            Thread.Sleep(TimeSpan.FromMilliseconds(2500));
            Console.SetCursorPosition(56, 6);
            Console.WriteLine("       ");
            Console.ResetColor();
        }
        public void DisplayPlayer(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.WriteLine("C");
        }
        public void DisplayMonster(Monster monster)
        {
            Console.SetCursorPosition(monster.PositionX, monster.PositionY);
            Console.WriteLine("M");
        }
        public void DisplayFeed(Monster monster)
        {
            Console.SetCursorPosition(monster.PositionX, monster.PositionY);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(".");
            Console.ResetColor();
        }
    }
}
