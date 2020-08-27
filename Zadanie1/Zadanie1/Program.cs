using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нам дано следующее задание:");
            Console.WriteLine("Найти сумму 2^(2) + 2^(3) + 2^(4) + … + 2^(10). Операцию возведения в степень не использовать.");
            int pow = 10;
            Summ(pow);
            Console.Write("Данная сумма равна: ");
            Console.WriteLine(Summ(pow));
            
        }

        static int Summ(int power)
        {
            int s = 1;
            for (int i =1; i <= power; i++)
            {
                s = s * 2; 
            }
            if (power == 2)
                return 4;
            else
                return s + Summ(--power);
        }

        
    }
}
