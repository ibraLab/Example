using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя циклы и метод:
Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).
Выведите на экран:
· равносторонний треугольник 
*/

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, x, z;

            Console.Write("Введите x: ");
            x = int.Parse(Console.ReadLine());

            y = x;
            z = 1;

            for (int i = 0; i < x; i++)             //количество рядов звездочек
            {
                for (int j = 0; j < y; j++)         //пробелы
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)         //звездочки
                {
                    Console.Write("*");
                }
                y -= 1;
                z += 2;
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
