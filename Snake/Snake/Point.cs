﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point : Figure
    {
        //location of the point
        int x;
        int y;

        //current symbol
        char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;

            this.symbol = symbol;
        }

        //shifting of the snake point
        public void ShiftedPoint(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    y += offset;
                    break;
                case Direction.Up:
                    y -= offset;
                    break;
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Left:
                    x -= offset;
                    break;
            }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        //clear * symbol
        public void Clear()
        {
            symbol = ' ';

            DrawPoint();
        }

        //draw point
        public void DrawPoint()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
