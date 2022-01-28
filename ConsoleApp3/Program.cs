using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            MallardDuck duck1 = new MallardDuck();
            RedHeadDuck duck2 = new RedHeadDuck();
            RubberDuck duck3 = new RubberDuck();
            DecoyDuck duck4 = new DecoyDuck();
            Duck[] mas = new Duck[] { duck1, duck2, duck3, duck4 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
               if (mas[i] is Flyable)
                {
                    Console.WriteLine((mas[i] as Flyable).Fly());
                }
               if (mas[i] is Quackable)
                {
                    Console.WriteLine((mas[i] as Quackable).Quack());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
