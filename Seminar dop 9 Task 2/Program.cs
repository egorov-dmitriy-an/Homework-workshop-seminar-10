// Задача 2. Известно, что пароль длиной 3 символа
// состоит из латинских букв строчного регистра и цифр от 0 до 9.
// Напишите рекурсивный метод, который перебирает все комбинации паролей. 


using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 9 Задача 2 доп =============");
            Console.Write("Введите пароль длиной из 3 символов (строчных латинских букв или цифр от 0 до 9): ");
            string parol = Console.ReadLine();

            int i = 0;
            int j = 0;
            int k = 0;
            int count = 0;
            int mod = 0;

            void Search()
            {
                string key = string.Empty;

                string alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
                int leng = alphabet.Length;
                if (mod == 0)
                {
                    if (i < leng)
                    {
                        if (j < leng)
                        {
                            if (k < leng)
                            {
                                key = key + alphabet[i] + alphabet[j] + alphabet[k];
                                if (key != parol)
                                {
                                    Console.WriteLine("Вариант № " + (count + 1) + ", пароль -> " + key);
                                    k++;
                                    count++;
                                }
                                else
                                {
                                    mod = 1;
                                    Console.WriteLine("Искомый пароль вариант № " + (count + 1) + ", пароль -> " + key);
                                }
                            }
                            else
                            {
                                j++;
                                k = 0;
                            }
                        }
                        else
                        {
                            i++;
                            j = 0;
                        }
                    }
                    Search();
                }
            }
            Search();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}