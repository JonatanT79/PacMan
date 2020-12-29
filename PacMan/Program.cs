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
//Fix movement for monster