using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    class GameOver
    {
        public void GameOverForUser()
        {
            Console.Clear();
            Console.WriteLine("GameOver!!");
            Environment.Exit(0);
        }
    }
}
