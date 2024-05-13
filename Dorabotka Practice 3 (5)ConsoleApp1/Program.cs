using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorabotka_Practice_3__5_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Напишите максимальное целое число диапазона: ");
            int n = int.Parse(Console.ReadLine());
            int x = r.Next(0, n);
            int count = 0;
            for (; ; )
            {
                Console.WriteLine("Отгадайте загаданное число");
                string input = Console.ReadLine();
                count++;
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Загаданным числом было: {x}");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    int userNumber = int.Parse(input);
                    if (userNumber < x)
                    {
                        Console.WriteLine("Число меньше загаданного. Возьмите побольше.");
                    }
                    else if (userNumber > x)
                    {
                        Console.WriteLine("Число больше заагаданного. Возьмите поменьше.");
                    }
                    else
                    {
                        Console.WriteLine($"Вы угадали, это {x}");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
