using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hui;
            Console.WriteLine("Введите первое число");
            while (!int.TryParse(Console.ReadLine(), out hui))
            {
                Console.WriteLine("Введите число !");
            }
            Console.WriteLine("Ваше число " + hui);
            int pizda;
            Console.WriteLine("Введите второе число");
            while (!int.TryParse(Console.ReadLine(), out pizda)) 
            {
                Console.WriteLine("Введите число !");
            }

            Console.WriteLine("Ваше число " + pizda);
            int uliana = pizda + 1;
            for (int i = hui; i < uliana; i++)
                
            {
                Console.WriteLine(i);
            }
            Console.ReadKey(); 
        }
    }
}
