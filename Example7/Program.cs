using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет.
Если выслуга до 5 лет, премия составляет 10% от заработной платы.
Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.
Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы.
Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы.
Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы.
Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы.
Результаты расчета, выведите на экран.*/


namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vysl;
            double prem, zp, percent=0;

            Console.Write("Введите значение заработной платы:");
            zp = double.Parse(Console.ReadLine());

            Console.Write("Введите выслугу сотрудника:");
            vysl = int.Parse(Console.ReadLine());

                if (vysl < 5) percent = 0.1;

                if (vysl >= 5 && vysl < 10) percent = 0.15;

                if (vysl >= 10 && vysl < 15) percent = 0.25;

                if (vysl >= 15 && vysl < 20) percent = 0.35;

                if (vysl >= 20 && vysl < 25) percent = 0.45;

                if (vysl >= 25) percent = 0.50;

            prem = zp * percent;

            Console.WriteLine($"Премия составляет: {prem}");
            Console.ReadKey();

        }
    }
}
