// Задача 3. Дано натуральное число n > 1. 
// Вывести все простые множители данного числа.
// 10 >> 5, 2.
// 12 >> 2, 2, 3.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 10 Задача 3 ==================");
            string numbers = string.Empty;
            string Mnozitel(int methodNumber, int tempNumber)
            {
                if (methodNumber != 1)
                {
                    if (methodNumber % tempNumber == 0)
                    {
                        numbers = numbers + tempNumber + ", ";
                        methodNumber = methodNumber / tempNumber;
                        tempNumber = 2;
                    }
                    else
                    {
                        tempNumber++;
                    }
                    Mnozitel(methodNumber, tempNumber);
                }
                return numbers;
            }

            Console.Write("Введите нвтуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Все простые множители данного числа: ");
            Console.WriteLine(Mnozitel(number, 2));
            Console.WriteLine("======================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}