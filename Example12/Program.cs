using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задано натуральное число x. Найдите число способов представить его в виде суммы четырех натуральных чисел:
x = a + b + c + d, где a ≤ b ≤ c ≤ d. (0-не натуральное число. Натуральные числа 1, 2, 3,.....) т.е. x>4 */

namespace Example12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, num;
            a = b = c=d=1;
            num = 0;

            do
            {
                Console.Write("Введите число x: ");
                x = int.Parse(Console.ReadLine());
            }

            while (x<4);

            for (c = 1; c<=d; c++)
            {
                for (b = 1; b <= c; b++)
                {
                    for (a = 1; a<=b; a++)
                    {
                        d = x - (a + b + c);
                        if (d >= c)
                            num += 1;
                    }
                }
            }
            Console.WriteLine($"num={num}");
            Console.ReadKey();
        }
    }
}
    

