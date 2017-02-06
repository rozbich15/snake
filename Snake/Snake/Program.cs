﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of the points for border lines
            List<Point> points = new List<Point>();

            //Intitialization of game constats
            const int HORIZONT_BORDER = 70;
            const int VERTICAL_BORDER = 30;

            const int BUFFER_WIDTH = 70;
            const int BUFFER_HEIGHT = 30;

            //set window size
            Console.SetWindowSize(BUFFER_WIDTH, BUFFER_HEIGHT);
            Console.SetBufferSize(BUFFER_WIDTH, BUFFER_HEIGHT);


            //start point
            int startX = 0;
            int startY = 1;

            char symbol = '#';

            HorizontalLine horizontalLine = new HorizontalLine(HORIZONT_BORDER, startX, startY, symbol);
            VerticalLine verticalLine = new VerticalLine(VERTICAL_BORDER, startX, startY, symbol);

            //draw top and bottom borders
            horizontalLine.DrawTopHorizontalLine();
            horizontalLine.DrawBottomHorizontalLine(BUFFER_HEIGHT);

            //draw left and right border
            verticalLine.DrawLeftVerticalLine();
            verticalLine.DrawRightVerticalLine(BUFFER_WIDTH);

            //set cursor in the center
            Console.SetCursorPosition(BUFFER_WIDTH / 2, BUFFER_HEIGHT  / 2);

            Console.ReadKey();
        }
    }
}
