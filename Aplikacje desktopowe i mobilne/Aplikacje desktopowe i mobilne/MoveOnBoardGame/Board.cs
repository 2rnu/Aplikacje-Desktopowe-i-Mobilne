using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Board
    {
        private int topCorner = 5;
        private int leftCorner = 5;
        private int height = 20;
        private int width = 50;
        private ConsoleColor backGroundColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char borderChar = 'X';

        private List<AvailableField> availableFieldsOnTheBoard = new List<AvailableField>(); //List, w nawiasach <> musimy podać jaki typ chcemy  || bardziej rozbudowana tablica 


        public Board()
        {
            CompleteAvailableFields();
        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;

            //górna krawędź
            Console.SetCursorPosition(topCorner, leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            //krawędź boczna
            for (int i = 1; i < height - 1; i++)
            {
                //lewa
                Console.SetCursorPosition(topCorner, i + leftCorner);
                Console.Write(borderChar);

                Console.SetCursorPosition(width - 1 + topCorner, i + leftCorner);
                Console.Write(borderChar);
            }

            Console.SetCursorPosition(topCorner, height - 1 + leftCorner);

            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            Console.ResetColor();
        }

            public bool CollisionDetect(int x, int y) // CollisonTime ma być ale nie działa
            {
            /*for (int i = 0; i < availableFieldsOnTheBoard.Count; i++)
            {
                if(availableFieldsOnTheBoard[i].X == x && availableFieldsOnTheBoard[i].Y == y)
                    return false;
            }*/

            foreach (AvailableField field in availableFieldsOnTheBoard) //przejdzie całą kolekcje (zaczyna od 0 do końca)  || nie można jej użyć, gdy chce się jej użyć od końca lub, gdy chcemy 
            {
                if (field.X == x && field.Y == y)
                    return false;
            }

            //kolizja ze ścianą planszy
            return true;

            /*
            if (y == leftCorner) //górna ściana || topCorner = x   || leftCorner = y
                return true;

            if (x == topCorner) //lewa ściana
                return true;

            if (y == height-1 + leftCorner) //dolna ściana
                return true;

            if (x == width-1 + topCorner) // prawa ściana
                return true;
            
                return false;*/
            }
            private void CompleteAvailableFields()
            {
                for(int x = topCorner + 1; x <= width + topCorner-2; x++)
                {
                
                    for (int y = leftCorner + 1; y <= height + leftCorner - 2; y++)
                    {
                    AvailableField availableField = new AvailableField();
                    availableField.X = x;
                    availableField.Y = y;

                    availableFieldsOnTheBoard.Add(availableField); //Add - dodaje obiekt do naszej 

                    }
                
                }

            }
        public AvailableField GetRandomAvailableField()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, availableFieldsOnTheBoard.Count); //count - ile jest dostępnych pól    ||    .Next(minValue- minimalna wartość, maxValue- maksymalna wartość)

            AvailableField availableField = availableFieldsOnTheBoard[randomNumber];

            return availableField;
        }
    }
}
