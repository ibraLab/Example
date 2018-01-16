using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дано два числа A и B (A<B) выведите сумму всех чисел расположенных между данными числами на экран.

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, sum;

            do
            {
                Console.Write("Введите значение числа а: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Введите значение числа b: ");
                b = int.Parse(Console.ReadLine());
            }

            while (a > b);
        
            sum =0; 
            for (i = a+1; i<b; i++)
                sum = sum + i; 
            
            Console.WriteLine($"Сумма чисел расположенных между a и b равна: {sum}");
            Console.ReadKey();
        }
    }
}
