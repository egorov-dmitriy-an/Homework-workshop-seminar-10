// Задача 2. Дана монотонная последовательность,
// в которой каждое натуральное число n встречается 
// ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
// Дано число m. Выведите первые m членов этой последовательности.
// m = 5 >> 1, 2, 2, 3, 3

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 10 Задача 2 ==================");
            string sequen = string.Empty;
            int count = 0;

            string Sequence(int limit)
            {
                count++;
                if (sequen.Length < limit * 3)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (sequen.Length < limit * 3)
                        {
                            sequen = sequen + count + ", ";
                        }
                    }
                    Sequence(limit);
                }
                return sequen;
            }
            Console.Write("Введите число выводимых членов послеовательности: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первые " + index + " членов последовательности: ");
            Console.WriteLine(Sequence(index));
            Console.WriteLine("======================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
