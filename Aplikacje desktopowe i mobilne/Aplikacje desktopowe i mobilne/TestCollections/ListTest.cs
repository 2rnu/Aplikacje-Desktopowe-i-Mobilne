using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class Test
    {
        public void ListTest()
        {

            //Lista Int

            List<int> listOfInts = new List<int>();

            Console.WriteLine("Ilość elementów w kolekcji int'ów: " + listOfInts.Count);

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                listOfInts.Add(random.Next(0, 21));
            }

            Console.WriteLine("Lista wylosowanych int'ów");
            for (int i = 0; i < listOfInts.Count; i++)
            {
                Console.WriteLine(listOfInts[i] + "  ");
            }
            Console.WriteLine();

            //Lista Double

            List<double> listOfDoubles = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                listOfDoubles.Add(Math.Round(random.NextDouble() * 20, 2));
            }

            Console.WriteLine("Lista wylosowanych double'ów");
            foreach (var item in listOfDoubles)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Max w int'ach: " + MaxFromInts(listOfInts));
            Console.WriteLine("Max w int'ach: " + MaxFromAllTypes<int>(listOfInts, CheckTwoInts));
            Console.WriteLine("Max w int'ach: " + MaxFromAllTypes<int>(listOfInts, (int a, int b) =>
                                                                                   {
                                                                                        return a> b;
                                                                                   }));
            
            Console.WriteLine("Max w double'ach: " + MaxFromDoubles(listOfDoubles));
            Console.WriteLine("Max w double'ach: " + MaxFromAllTypes<double>(listOfDoubles, CheckTwoDoubles));
            Console.WriteLine("Max w double'ach: " + MaxFromAllTypes<double>(listOfDoubles, (a, b) => a > b));
        }

        private bool CheckTwoInts(int a, int b)
        {
            return a > b
        }

        private bool CheckTwoDoubles(double a, double b)
        {
            return a > b;
        }


        private int MaxFromInts(List<int> list)
        {
            int max = list[0];

            foreach (int item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;

        }
        private double MaxFromDoubles(List<double> list) //is - sprawdzamy czy jest danego typu - np. (maxi is int) - sprawdza czy maxi to int
        {
            double max = list[0];

            foreach (double item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        
        //różnice próbujemy dostać w parametrach
        //stałe wartości - parametry
        //wartość - typ

        //Typy generyczne - warto zapamiętać, bardzo przydatne

        private T MaxFromAllTypes<T>(List<T> list, Func<T, T, bool> check)
        {
            T max = list[0];

            foreach (T item in list)
            {
                if (check(item, max))
                    max = item;
            }
            return max;
        }
        //Jest to tylko szablon, nigdy nie zostanie wywołany

        //action- parametr jako funkcje, która nic nie zwraca
        //funs - ??????, która zwaraca - Func<*, *, wartość zwracana>
    }
}
