using System;

namespace PolymorphismApp

//Zasada DYR - znaczy "Don't Repeat Yourself" - "Nie powtarzaj się"

    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            /*można też Dog fisrtDog;
             * Dog firstDog = new Dog(); */
            Dog secondDog = new Dog("Burek", 5);

            Dog thirdDog = new Dog(secondDog);

            firstDog.ShowInfo();
            secondDog.Bark();
            thirdDog.ChasePostman();


            Cat firstCat = new Cat("Mruczek", 5);

            firstCat.ShowInfo();
            firstCat.Meow();
            firstCat.ClimbOnTree();

        }
        
        static void ShowInfoForDog(Dog dog)
        {
            dog.ShowInfo();
        }
            static void ShowInfoForCat(Cat cat)
        {
            cat.ShowInfo();
        }

    }
