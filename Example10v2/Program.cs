using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.

namespace Example10
{
    public class EnterNumber
    {
        static int EnterNumber(int a, int b)
        {
            Console.Write("Введите значение числа а: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение числа b: ");
            b = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
       

        static void Main(string[] args)

        {
            int a, b, i, sum;



            Console.Write("Введите значение числа а: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение числа b: ");
            b = int.Parse(Console.ReadLine());

            for (i = 1; a > b; i++)
            {
                while (a > b)
                {
                    Console.WriteLine("a должно быть меньше b");
                    Console.Write("Введите значение числа а: ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Введите значение числа b: ");
                    b = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"a={a}, b={b}");

            for (sum = ++a; sum < b; sum++)
                if ((sum % 2) != 0)
                    Console.Write($"{sum}\t");
            Console.ReadKey();
        }
    }
}








