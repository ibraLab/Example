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
            int num;
            Console.Write("Введите число от 1 до 100: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 14)
            {
                Console.WriteLine("Число входит в числовой промежуток [0-14]");
                if (num >= 15 && num <= 35)
                    Console.WriteLine("Число входит в числовой промежуток [15-35]");
                if (num >= 36 && num <= 50)
                    Console.WriteLine("Число входит в числовой промежуток [36-50]");
                if (num >= 50 && num <= 100)
                    Console.WriteLine("Число входит в числовой промежуток [50-100]");
            }
            else Console.WriteLine("Число не входит в указанный числовой промежуток");
            Console.ReadKey();
        }

    }
}