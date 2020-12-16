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
        public void TryDetectWallHit(string mapSymbol, Player player, Coordinate coordinate)
        {
            if (mapSymbol != "#")
            {
                player.PositionX = coordinate.X;
                player.PositionY = coordinate.Y;
            }
        }
        public void TryDetectMonsterHit() { }
    }
}
