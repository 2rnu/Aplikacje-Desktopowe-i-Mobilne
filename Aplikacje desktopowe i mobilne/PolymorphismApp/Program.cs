using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            /*można też Dog fisrtDog;
             * Dog firstDog = new Dog(); */
            Dog secondDog = new Dog("Burek", 5);
           
            Dog thirdDog = secondDog;

            
        }
    }
}
