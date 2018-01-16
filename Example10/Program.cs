using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.

namespace Example10
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b, sum;

            do
            {
                Console.Write("Введите значение числа а: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Введите значение числа b: ");
                b = int.Parse(Console.ReadLine());
            }

            while (a > b);

            Console.WriteLine($"a={a}, b={b}");

            for (sum = ++a; sum < b; sum++)
                if((sum%2)!=0)
                Console.Write($"{sum}\t");
                Console.ReadKey();
        }
    }
}
    


    




