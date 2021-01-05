using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Movement movement = new Movement();
            Display display = new Display();
            Player player = new Player(3);

            map.PrintMap1();
            display.DisplayStats(0, player);
            display.DisplayReady(player);
            movement.MovePlayer(map.Map1);
        }
    }
}
//Fix so monster is moving closer to player
//Monster pos: x = 57, y = 4;
//Player pos: x = 59, y = 10;

//börja göra så att ex. X:et matcher, därefter: if: m.x == p.x då börja med y.