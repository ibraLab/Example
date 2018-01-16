using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Известно, что у четных чисел младший бит имеет значение 0
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи. 

    НЕПРАВИЛЬНО! ПЕРЕДЕЛАТЬ!*/

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите значение а: ");
            a = int.Parse(Console.ReadLine());

            if (a & 1=0)
                Console.WriteLine("Число a четное");
            if (a & 0 = 1)
                Console.WriteLine("Число a нечетное");
            Console.ReadKey();

        }
    }
}
