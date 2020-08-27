using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Добро пожаловать в программу определения дня недели!");
            Days d = (Days)DaysControl();
            Console.Write("Today ");//output
            DaysOfWeek(d);
        }

        enum Days //a eto enum))
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void DaysOfWeek(Days d) //method to select day
        {
            switch (d)
            {
                case Days.Monday:
                    Console.WriteLine("Monday!");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Tuesday!");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Wednesday!");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Thursday!");
                    break;
                case Days.Friday:
                    Console.WriteLine("Friday!");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Saturday!");
                    break;
                case Days.Sunday:
                    Console.WriteLine("Sunday!");
                    break;
            }
        }

        static int DaysControl () //method to input nums and validation check
        {
            int num;
                Console.Write("Введите номер дня недели (число от 1 до 7): ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out num))
                {
                    if (num < 7 && num > 1)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Читайте внимательно! Сказано от 1 до 7!");
                        Console.WriteLine("Попробуйте еще раз!");
                        return DaysControl();
                    }
                }
                else
                {
                    Console.WriteLine("Читайте внимательно! Сказано ЧИСЛО!");
                    Console.WriteLine("Попробуйте еще раз!");
                    return DaysControl();
                }
        }
                
    }
}
