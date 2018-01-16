using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Напишите программу - консольный калькулятор.  
Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые  произвольные значения. 
Предложите пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его в строковую переменную sign.  
Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
Выведите на экран результат выполнения арифметической операции.  
В случае использования операции деления, организуйте проверку попытки деления на ноль.
И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.*/

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2, sign;


            Console.Write("Введите первое число: ");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите знак арифметической операции: ");
            char math_oper = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            operand2 = Convert.ToDouble(Console.ReadLine());

            switch (math_oper)
            {
                case '+': sign = operand1 + operand2;
                    Console.Write("Сумма введенных чисел равна: {0}+{1}={2} ", operand1, operand2, sign);
                    break;
                case '-': sign = operand1 - operand2;
                    Console.Write("Разность введенных чисел равна: {0}-{1}={2} ", operand1, operand2, sign);
                    break;
                case '*':
                    sign = operand1 * operand2;
                    Console.Write("Произведение введенных чисел равно: {0}*{1}={2} ", operand1, operand2, sign);
                    break;
                case '/':
                    sign = operand1 / operand2;
                   if (operand2 == 0) 
                    {

                        Console.WriteLine("Деление на 0 запрещено");
                        break;
                    }
                    Console.WriteLine("Частное введенных чисел равно: {0}/{1}={2} ", operand1, operand2, sign);
                    break;
                default:
                break;
            }
            
            Console.ReadKey();
        }
    }
}
