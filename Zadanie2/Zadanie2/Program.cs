using System;
using System.Security.Cryptography.X509Certificates;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу нахождения НОД числа!");
            string report = "первое";
            int x = NumInput(report);
            report = "второе";
            int y = NumInput(report);
            NOD(x, y);
            Console.WriteLine("НОД = {0}", NOD(x, y)); //output
        }

        static int NumInput(string word) //method to input numbers and validation check
        {
            int nums = 0;

                Console.Write($"Введите {word} число: ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out nums))
                {
                    if (nums < 1)
                    {
                        Console.WriteLine("Введите положительное число!");
                        return NumInput(word);
                    }
                    else
                    {
                        return nums;
                    }
                }
                else
                {
                    Console.WriteLine("Введите ЧИСЛО, а не буквы!");
                    return NumInput(word);
                }
        }

        static int NOD(int num1, int num2) //method to find NOD (by Euclidian algorithm)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
                else
                    num2 = num2 - num1;
            }
            return num1;
        }
    }
}
