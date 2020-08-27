using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для нахождения степени числа");
            string report = "число";
            int number = AskNums(report);
            report = "степень";
            int power = AskNums(report);
            PowerMethod(number, power);
            int result = PowerMethod(number, power);
            Console.WriteLine($"число {number} в степени {power} равно: {result}");//output
        }

        static int AskNums (string word) //method to intput numbers and validation check
        {
            int nums = 0;

                Console.Write($"Введите {word}: ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out nums))
                {
                    return nums; 
                }
                else
                {
                    Console.WriteLine("Введены неверные данные! Повторите попытку.");
                    return AskNums(word);
                }

        }

        static int PowerMethod (int num, int pow) //method for raising a number to a power
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                return num * PowerMethod(num, pow -1);
            }
                
        }
    }
}
