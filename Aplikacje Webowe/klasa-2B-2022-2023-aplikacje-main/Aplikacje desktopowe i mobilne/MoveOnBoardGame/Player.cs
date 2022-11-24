using System;
using MoveOnBoardGame.Enums;

namespace MoveOnBoardGame
{
    class Player
    {
        private ConsoleColor backGroundColor = ConsoleColor.White;
        private ConsoleColor foregroundColor = ConsoleColor.Green;
        private char playerChar = 'Q';

        private int currX = 1;
        private int currY = 1;
       
        private int prevX = 1;
        private int prevY = 1;

        public int CurrX
        {
            get
            {
                return currX;    //properties tylko do odczytu, nie można edytować.
            }
        }

        public int CurrY
        {
            get
            {
                return currY;    //properties tylko do odczytu, nie można edytować.
            }
        }

        public Player(int startX, int startY)
        {
            currX = prevX = startX;
            currY = prevY = startY;
            Draw();

        }
        public void Move(MoveDirection direction)
        {
            //char pressKey = Console.ReadKey(true).KeyChar;


            switch (direction)
            {

                case MoveDirection.MOVE_UP:
                    currY--;
                    break;

                case MoveDirection.MOVE_DOWN:
                    currY++; 
                    break;

                case MoveDirection.MOVE_LEFT:
                    currX--;
                    break;

                case MoveDirection.MOVE_RIGHT:
                    currX++;
                    break;

                default:
                    break;

            }

            Draw();

        }

        private void Draw()
        {
            Console.ResetColor();
            Console.SetCursorPosition(prevX, prevY);
            Console.Write(' ');

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;
            Console.SetCursorPosition(currX, currY);
            Console.Write(playerChar);

            prevX = currX;
            prevY = currY;
            Console.ResetColor();
        }

    }
}
