using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Вычислить среднее арифметическое 3 целочисленных значений и вывести его на экран. С каакой проблемой столкнулись? 
 Какой тип переменных лучше использовать для корректного отображения результата*/
  
namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
          
            Console.WriteLine("Введите значение переменной a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение переменной b: ");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите значение переменной c: ");
            c = int.Parse(Console.ReadLine());

           float res = (float)(double)(a + b + c) /3;
            Console.WriteLine($"res= {res}");

            Console.ReadKey();



        }
    }
}
