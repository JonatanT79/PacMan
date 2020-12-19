using System;
using static PacMan.Symbols;

namespace PacMan
{
    class Detection
    {
        public bool TryDetectFeedHit(string mapSymbol, ref int score)
        {
            if (mapSymbol == Feed)
            {
                score += 10;
                return true;
            }
            return false;
        }
        public void TryDetectWallHit(string mapSymbol, Player player, Coordinate coordinate)
        {
            if (mapSymbol != WALL)
            {
                player.PositionX = coordinate.X;
                player.PositionY = coordinate.Y;
            }
        }
        public void TryDetectMonsterHit(string mapSymbol, ref Player player)
        {
            GameOver gameOver = new GameOver();

            if (mapSymbol == MONSTER)
            {
                player.Life--;
                player = new Player(player.Life);

                if (player.Life <= 0)
                {
                    gameOver.GameOverForUser();
                }
            }
        }
    }
}
