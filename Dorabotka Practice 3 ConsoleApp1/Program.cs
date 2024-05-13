using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorabotka_Practice_3_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                bool firstNumber = false;
                Console.WriteLine("Напишите число на простоту: ");
                string userInput = Console.ReadLine();
                int num = Convert.ToInt32(userInput);
                int divider = 2;
                while (divider <= num - 1)
                {
                    int remains = num % divider;
                    if (remains == 0)
                    {
                        firstNumber = true;
                        break;
                    }

                    divider++;
                }
                if (firstNumber)
                {
                    Console.WriteLine("Составное");
                }
                else
                {
                    Console.WriteLine("Простое");
                }                
            }
            Console.ReadKey();
        }
    }
}
