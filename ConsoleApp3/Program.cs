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

            Duck[] mas = new Duck[] { duck1, duck2 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
                Console.WriteLine(mas[i].quack());
            }

            Console.ReadKey();
        }

    }
}
