using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Dog
    {
        private string name;
        private byte age;

        public Dog()
        {
            name = "Michał";
            age = 10;
        }

        public Dog(string name, byte age)
        {
            this.name = name;
            this.age = age;
            //this. daje kierunek do parametru TEGO (chyba pierwszego)
        }
            
        public Dog(Dog dogToCopy)
        {
            name = dogToCopy.name;
            age = dogToCopy.age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Pies o imieniu" + name + "ma " + age + " lat");
            Console.WriteLine("*****************************");
        }

        public void Bark()
        {
            Console.WriteLine("Pies o imieniu " + name + " szczeka");
        }

        public void ChasePostman()
        {
            Console.WriteLine("Pies o imieniu " + name + " goni listonosza");
        }

        public void ShowInfo()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Przedstawienie psa: ");
            Console.WriteLine(type + " o imieniu" + name + "ma " + age + " lat");
            Console.WriteLine("=============================");

            //virtual lub everride, bez nich jest tkz. krótkie wiązanie
            //virtual - nie zostanie wywołona, tylko rzeczywiście będzie szukana metoda, którą szukamy, czyli najpierw przejdzie do animal(virtual), a potem dog(override), dodam że w ShowInfo(), proszono o Dog.
            //polimorphysm - "wielopostaciowy"   ||    Jest bardzo często wykorzystywany, UCZ SIĘ!
        }
    }
}
