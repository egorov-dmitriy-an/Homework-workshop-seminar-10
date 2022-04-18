// Задача 1. Дано предложение. Напишите рекурсивный метод,
// подсчитывающий количество слов в данном предложении.
// Словом считается последовательность символов без пробелов.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 9 Задача 1 доп =============");
            int slovo = 0;
            int Word(string methodText, int count, int index)
            {
                if (index < methodText.Length)
                {
                    if (methodText[index] == ' ')
                    {
                        count++;
                    }
                    index++;
                    slovo = count;
                    Word(methodText, count, index);
                }
                return slovo;
            }

            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            Console.WriteLine("Количество слов в предложении: " + Word(text, 1, 0));
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}