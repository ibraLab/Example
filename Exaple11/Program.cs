using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Используя циклы и метод:
Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).
Выведите на экран:
· прямоугольник
· прямоугольный треугольник
· равносторонний треугольник 
· ромб
*/
namespace Exaple11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, num1, num2;

            Console.Write("Введите значение num1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите значение num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (i = 0; i <= num1; i++)               //Прямоугольник
            {
                for (j = 0; j <= num2; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }
            Console.WriteLine();

            for (i = 1; i < num1; i++)               //Прямоугольный треугольник
            {
                for (j = 1; j<=i ; j++)
                Console.Write("*");
                Console.Write("\n");
            }
            Console.WriteLine();             
            Console.ReadKey();

        }
    }
}
