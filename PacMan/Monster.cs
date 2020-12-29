using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    class Monster
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public List<Monster> MonsterList()
        {
            List<Monster> monsters = new List<Monster>()
            {
                new Monster() {PositionX = 57, PositionY = 4}
            };

            return monsters;
        }
    }
}
