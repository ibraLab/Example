using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу определения, попадает ли указанное пользователем
число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.*/


namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 100: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 0 && a <= 14)
                Console.WriteLine("Число входит в числовой промежуток [0-14]");
            if (a >= 15 && a <= 35)
                Console.WriteLine("Число входит в числовой промежуток [15-35]");
            if (a >= 36 && a <= 50)
                Console.WriteLine("Число входит в числовой промежуток [36-50]");
            if (a >= 50 && a <= 100)
                Console.WriteLine("Число входит в числовой промежуток [50-100]");
            if (a>100)
            Console.WriteLine("Число не входит в указанный числовой промежуток");
            Console.ReadKey();
        }
        
    }
}

