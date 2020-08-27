using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для нахождения суммы чисел в заданном интервале!");
            string report = "первое";
            int num1 = AskNums(report);
            report = "второе";
            int num2 = AskNums(report);
            int min;
            int max;
            if (num1 < num2) //присваиваем значения переменных к min и max
            {
                min = num1;
                max = num2;
            }
            else
            {
                min = num2;
                max = num1;
            }
            Sum(min, max);
            Console.Write($"Сумма чисел в диапазоне[{min}; {max}] равна: ");//ouput
            Console.WriteLine(Sum(min, max));
        }

        static int AskNums(string word) //method to input numbers and validation check
        {
            int nums = 0;
                Console.Write($"Введите {word} число: ");
                string input = Console.ReadLine();
                if(Int32.TryParse(input, out nums))
                return nums;
                else
                {
                Console.WriteLine("Введены неверные данные! Повторите попытку.");
                return AskNums(word);
                }
        }

        static int Sum(int num1s, int num2s) //method to find summ
        {
            if (num1s >= num2s)
                return num2s;
            else
                return num1s + Sum(num1s+1, num2s);
        }
    }
}
