using System;
using System.ComponentModel.DataAnnotations;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует игра «Быки и коровы»!"); //greeting and rules
            Console.WriteLine("Не начинайте игру, если не собираетесь довести ее до конца! \nЕсли готовы, то нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine("Правила следующие: Вы вводите четырёхзначное число.\nЕсли вы угадаете цифру без совпадения её позиции с цифрой в загаданном числе, то вы получаете корову.\nЕсли вы угадаете цифру и её позиция совпала с позицией цифры в загаданном числе, то вы получаете быка.\nУ вас будет 10 попыток.");
            Console.WriteLine("Если готовы то нажми на любую клавишу и мы начнем.\nИ запомни, удача любит рисковых!");
            Console.ReadKey();//start
            string rndnum = RandomNumber();//random number method
            char[] arrayrnd = rndnum.ToCharArray();
            int bulls = 0;
            int cows = 0;
            int tempb = 0;
            int tempc = 0;
            for (int k=0; k<10; k++)
                {
                int nums1 = NumInput();
                string nums = nums1.ToString();
                char[] arrayinput;
                arrayinput = nums.ToCharArray();
                for (int i = 0; i < arrayinput.Length; i++)
                {
                    for (int j = 0; j < arrayrnd.Length; j++)
                    {
                        if (arrayinput[i] == arrayrnd[j] && i == j)
                        {
                            bulls++;
                        }
                        else if (arrayinput[i] == arrayrnd[j] && i != j)
                        {
                            cows++;
                        }
                        else if (arrayinput[i] != arrayrnd[j] && i != j)
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine($"{bulls} быка, {cows} коровы");
                if (bulls != 4)
                {
                    tempb = bulls;
                    bulls = 0;
                    tempc = cows;
                    cows = 0;
                    continue;
                }
                else if (bulls == 4)
                {
                    break;
                }
                    
                }
            if (bulls == 4)
                Console.WriteLine("Вы выиграли!");
            else
                Console.Write("К сожалению вы проиграли. Загаданное число было: ");
            Console.WriteLine(arrayrnd);
        }

        static int NumInput() //numbers input and validation method
        {
            int nums = 0;
            Console.WriteLine("Введите четырёхзначное число.");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if(nums < 1000) 
                {
                    Console.WriteLine("Вводимое число должно быть положительным и четырёхзначным!");
                    return NumInput();
                }
                else if (nums > 9999)
                {
                    Console.WriteLine("Вводимое число должно быть четырёхзначным!");
                    return NumInput();
                }
                else
                {
                    return nums;
                }
                }
                else
                {
                Console.WriteLine("ЧИСЛО Карл, ЧИСЛО!");
                return NumInput();
            }
        }
        static string RandomNumber() //random number validation method
        {
            int i = 0;
            Random rnd = new Random();
            int value1 = rnd.Next(999, 10000);
            string value = value1.ToString();
            char[] arrayrnd = value.ToCharArray();

            if (arrayrnd[i] == arrayrnd[i + 1])
                return RandomNumber();
            else if (arrayrnd[i] == arrayrnd[i + 2])
                return RandomNumber();
            else if (arrayrnd[i] == arrayrnd[i + 3])
                return RandomNumber();
            else if (arrayrnd[i + 1] == arrayrnd[i + 2])
                return RandomNumber();
            else if (arrayrnd[i + 1] == arrayrnd[i + 3])
                return RandomNumber();
            else if (arrayrnd[i + 2] == arrayrnd[i + 3])
                return RandomNumber();
            else
                return value;
        }

    }
}
