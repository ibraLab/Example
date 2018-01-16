using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Имеется 3 переменные типа int x = 5, y = 10, и z = 15;

Выполните и рассчитайте результат следующих операций для этих переменных:
 x += y >> x++ * z;
 z = ++x & y* 5;
 y /= x + 5 | z;
 z = x++ & y* 5;
 x = y << x++ ^ z;*/



namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 5, y = 10, z = 15;

            x+=y>>x++*z;
            Console.WriteLine("x={0}, y={1}, z={2}", x,y,z);
            Console.WriteLine("result={0}", y >> x++ * z);
            

            z = ++x & y * 5;
            Console.WriteLine("z={0}",z);
                                                              //  000110 
                                                              //110010       
            y /= x + 5 | z;                                   //000010
            Console.WriteLine("y={0}", y);

            z = x++ & y * 5;
            Console.WriteLine("z={0}", z);

            x = y << x++ ^ z;
            Console.WriteLine("x={0}", x);

            Console.ReadKey();


        }
    }
}
