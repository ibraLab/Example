using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Имеется 3 переменные типа int x=10, y=12 и z=3
// Выполнить и рассчитать результат следующих операций для переменных:
//x+=y-x++ *z
//z=--x-y*5
//y-=x+5%z
//z=x++ =y*5
//x=y-x++*z
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int x = 10, y = 12, z = 3;

            //x += y - x++ * z;                        //x=x+y-x*z  x=x+1
            //Console.WriteLine($"x={x}");

            //z = 3;
            //x = 10;
            //y = 12;
            //z = --x - y * 5;                         // z=x-1-y*5 
            //Console.WriteLine($"z={z}");

            z = 3;
            x = 10;
            y = 12;
            y /= x + 5 % z;                           //y=y/(x+ остаток[5/z])  12/(10+2)=1
            Console.WriteLine($"y={y}");

            z = 3;
            x = 10;
            y = 12;
            z = x++ +y * 5;                              //z=x+y*5        x=x+1 
            Console.WriteLine($"z={z}");

            z = 3;
            x = 10;
            y = 12;
            x = y - x++ * z;                             //x=y-x*z      x=x+1
            Console.WriteLine($"x={x}");
            Console.ReadKey();
        }
    }
}
