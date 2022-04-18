// Задача 1.Дано число n. Получите число, записанное в обратном порядке.
// 345 >> 543
// 81 >> 18
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 10 Задача 1 ==================");
            Console.Write("Введите исходное число:   ");
            string number = Console.ReadLine();

            string Reverse(string tempNumber, int index)
            {
                string revNumber = string.Empty;
                while (index < tempNumber.Length)
                {
                    revNumber = tempNumber[index] + revNumber;
                    index++;
                    Reverse(tempNumber, index);
                }
                return revNumber;
            }
            Console.WriteLine("Число в обратном порядке: " + Reverse(number, 0));
            Console.WriteLine("======================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}