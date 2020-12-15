using System;
using static PacMan.Symbols;
namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Movement movement = new Movement();
            map.PrintMap1();
            movement.MovePacMan(map.Map1);
        }
    }
    class Detection
    {
        public void DetectionCheckForWallHit(string[,] map, Player player)
        {
         
        }
        public void DetectionCheckForMonsterHit() { }
    }
}
//modifyposition - hitta en lösning där max 3 parameter finns