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
        private int width = 60;
        private ConsoleColor borderbackgroundColor = ConsoleColor.DarkRed;
        private ConsoleColor borderforegroundColor = ConsoleColor.Yellow;

        private ConsoleColor stonebackgroundColor = ConsoleColor.Green;
        private ConsoleColor stoneforegroundColor = ConsoleColor.Cyan;

        private char borderChar = 'O';
        private double percentOfStoneObstacles = 0.02;
        private char stoneChar = 'D';

        private List<AvailableField> availableFieldsOnTheBoard = new List<AvailableField>(); //List, w nawiasach <> musimy podać jaki typ chcemy  || bardziej rozbudowana tablica 


        public Board()
        {
            CompleteAvailableFields();
            GenerateRandomStoneObstacles();
        }

        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.ForegroundColor = borderforegroundColor;
            Console.BackgroundColor = borderbackgroundColor;

            //górna krawędź
            Console.SetCursorPosition(topCorner, leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            //krawędzie boczne
            for (int i = 1; i < height - 1; i++)
            {
                //lewa
                Console.SetCursorPosition(topCorner, i + leftCorner);
                Console.Write(borderChar);

                //prawa
                Console.SetCursorPosition(width - 1 + topCorner, i + leftCorner);
                Console.Write(borderChar);
            }

            //dolna krawędź
            Console.SetCursorPosition(topCorner, height - 1 + leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            Console.ForegroundColor = stoneforegroundColor;
            Console.BackgroundColor = stonebackgroundColor;

            List<AvailableField> listOfStone = availableFieldsOnBoard.Where(af => af.TypeOfObstacle == TypeOfObstacle.Stone).ToList();

            foreach (AvailableField item in listOfStone)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(stoneChar);
            }

            Console.ResetColor();
        }

        public bool CollisionDetect(int x, int y)
        {
            AvailableField availableField = availableFieldsOnBoard
                                            .FirstOrDefault(af => af.X == x && af.Y == y); //przechodzi przez cała kolekcje i zwraca to i tamto.
            if (availableField == null)
                return CollisionType.BorderCollision;

            if (availableField.TypeOfObstacle == TypeOfObstacle.Stone)
                return CollisionType.StoneCollision;

            /*for (int i = 0; i < availableFieldsOnBoard.Count; i++)
            {
                if (availableFieldsOnBoard[i].X == x && availableFieldsOnBoard[i].Y == y)
                return false;
            }*/

            foreach (AvailableField field in availableFieldsOnTheBoard) //przejdzie całą kolekcje (zaczyna od 0 do końca)  || nie można jej użyć, gdy chce się jej użyć od końca lub, gdy chcemy 
            {
                if (field.X == x && field.Y == y)
                    return CollisionType.NoCollision
            }

            //kolizja ze ścianą planszy
            return CollisionType.BorderCollision;
        }
        private void CompleteAvailableFields()
        {
            for (int x = topCorner + 1; x <= width + topCorner - 2; x++)
            {
                for (int y = leftCorner + 1; y <= height + leftCorner - 2; y++)
                {
                    AvailableField availableField = new AvailableField();
                    availableField.X = x;
                    availableField.Y = y;
                    availableField.TypeOfObstacle = TypeOfObstacle.None;

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

        private void GenerateRandomStoneObstacles()
        {
            int countOfStoneObstacles = (int)(height * width * percentOfStoneObstacles);

            Random random = new Random();

            List<AvailableField> listForStones = availableFieldsOnBoard
                .Where(af => af.TypeOfObstacle == TypeOfObstacle.None)
                .OrderBy(af => random.Next())
                .Take(countOfStoneObstacles)
                .ToList();

            foreach (var item in listForStones)
            {
                item.TypeOfObstacle = TypeOfObstacle.Stone;
            }
        }
}
