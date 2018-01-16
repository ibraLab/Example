using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу рассчета объема V и площади поверхности S цилиндра
//Объем V цилиндра радиусом R  и высотой h вычмсляется по формуле: V=ПR^2h
// Площадь поверхности цилиндра вычисляется по формуле: S=2ПR^2+2ПR^2=2ПR(R+h)/
// Результаты расчетов вывести на экран
namespace Exaple3
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, V, S, h;
            const double Pi=3.14;
          
            Console.WriteLine("Введите значение R: ");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = double.Parse(Console.ReadLine());

            S = 2 * Pi * R * (R + h);
            Console.WriteLine("Площадь цилиндра равна: {0} ", S);

            V = Pi * Math.Pow(R,2) * h;
            Console.WriteLine("Объем цилиндра равен: {0} ", V);

            Console.ReadKey();

        }
    }
}
