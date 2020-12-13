using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Movement movement = new Movement();
            map.PrintMap1();
            movement.MovePacMan();
        }
    }
}
