using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* z=Корень 11 степени из(9*x^2+3*y^3) при x<=0
 arcsin(x/y) при x>0, |y|>=x
 log по основанию (x+1) из (6*x+|y|) при x>0, |y|<x   */

namespace Example13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double z =0;

            Console.Write("Введите значение x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Введите значение y: ");
            y = int.Parse(Console.ReadLine());

            if (x <= 0)
                z = Math.Pow((9 * Math.Pow(x, 2) + 3 * Math.Pow(y, 3)),1/11);
            if (x > 0 && Math.Abs(y) >= x)
                z = Math.Asin(x / y);
            if (x > 0 && Math.Abs(y) < x)
                z = Math.Log((6 * x + Math.Abs(y)), ++x);

            Console.WriteLine($"z={z}");
            Console.ReadKey();






        }
    }
}
