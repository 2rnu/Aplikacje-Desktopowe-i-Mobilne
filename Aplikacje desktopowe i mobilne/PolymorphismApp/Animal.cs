using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// w c# można dziedziczyć tylko jedną klase, dlatego jest //: base(), a nie "Kolejna_klasa" ipt.:`

namespace PolymorphismApp
{
        class Animal
        {
            protected string name;
            protected byte age;

            public Animal()
            {
                name = "Lord Belzedup";
                age = 2;
            }

            public Animal(string name, byte age)
            {
                this.name = name;
                this.age = age;
                //this. daje kierunek do parametru TEGO (chyba pierwszego)
            }

            public Animal(Animal animalToCopy)
            {
                name = animalToCopy.name;
                age = animalToCopy.age;
            }

            public void ShowInfo()
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Zwierze o imieniu" + name + "ma " + age + " lat");
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
