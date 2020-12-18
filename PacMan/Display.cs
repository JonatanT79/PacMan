using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
