﻿using System;
using static PacMan.Symbols;

namespace PacMan
{
    class Map
    {
        const int ROWS = 15, COLUMNS = 33;
        public string[,] Map1 = new string[ROWS, COLUMNS]
        {
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" }
        };
        public void PrintMap1()
        {
            for (int row = 0; row < ROWS; row++)
            {
                Console.SetCursorPosition(43, row);

                for (int column = 0; column < COLUMNS; column++)
                {
                    string symbol = Map1[row, column];
                    ChangeSymbolColor(symbol);
                    Console.Write(symbol);
                }
                Console.WriteLine("");
            }
            Console.ResetColor();
        }
        private void ChangeSymbolColor(string symbol)
        {
            if (symbol == WALL)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (symbol == DOT)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
    }
}
