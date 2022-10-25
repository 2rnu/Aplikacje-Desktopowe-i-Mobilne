using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Zasada DYR - znaczy "Don't Repeat Yourself" - "Nie powtarzaj się"

namespace PolymorphismApp
{
    class Cat
    {
        private string name;
        private byte age;

        public Cat()
        {
            name = "Puszek";
            age = 2;
        }

        public Cat(string name, byte age)
        {
            this.name = name;
            this.age = age;
            //this. daje kierunek do parametru TEGO (chyba pierwszego)
        }

        public Cat(Cat catToCopy)
        {
            name = catToCopy.name;
            age = catToCopy.age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Kot o imieniu" + name + "ma " + age + " lat");
            Console.WriteLine("*****************************");
        }

        public void Meow()
        {
            Console.WriteLine("Kot o imieniu " + name + " miauczy");
        }

        public void ClimbOnTree()
        {
            Console.WriteLine("Kot o imieniu " + name + " wspina się na szosnę");
        }

    }
}
