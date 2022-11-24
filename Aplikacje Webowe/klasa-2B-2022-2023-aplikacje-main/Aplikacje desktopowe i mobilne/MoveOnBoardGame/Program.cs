using System;
using System.Threading;

namespace MoveOnBoardGame
{
   
    class Program
    {

        static void Main(string[] args)
        {
            var dane = Console.ReadKey(true).KeyChar;

            Board board = new Board();
            board.Draw();

            Player player = new Player();

            MoveDirection direction = MoveDirection.MOVE_RIGHT;

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    direction = (MoveDirection)Console.ReadKey(true).KeyChar;
                }
                player.Move(direction);
                
                if(board.CollisionDetect(player.CurrX, player.CurrY))
                {
                    break; // wychodzimy z nabliższej pętli/switch'a

                }

                Thread.Sleep(100);

               
            }

        }


    }
}
