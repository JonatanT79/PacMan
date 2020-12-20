using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    class Player
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Life { get; set; }

        public Player(int life)
        {
            PositionX = 59;
            PositionY = 10;
            Life = life;
        }
    }
}
