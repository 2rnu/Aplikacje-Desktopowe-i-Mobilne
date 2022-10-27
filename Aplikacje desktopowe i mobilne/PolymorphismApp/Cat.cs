using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Zasada DYR - znaczy "Don't Repeat Yourself" - "Nie powtarzaj się"

namespace PolymorphismApp
{
    class Cat : Animal
    {
        private string name;
        private byte age;

        public Cat()
        {
            name = "Puszek";
            age = 2;
        }

        public Cat(string name, byte age) : base(name, age)
        {
        }

        public Cat(Cat catToCopy) : base(catToCopy)
        {
           
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
