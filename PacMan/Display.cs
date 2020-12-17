using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    class Display
    {
        public void DisplayScore(int score)
        {
            Console.SetCursorPosition(55, 15);
            Console.WriteLine($"Score: {score}");
        }
    }
}
