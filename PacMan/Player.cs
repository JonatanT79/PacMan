﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    class Player
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Player()
        {
            PositionX = 45;
            PositionY = 12;
        }
    }
}