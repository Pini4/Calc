using System;

namespace Sgk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пржаловать в калькулятор v1!");
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какое действие вы хотите выполнить?");
            var enter = Console.ReadKey();
            char enter_key = enter.KeyChar;

            if (enter_key == '+')
            {
                Console.WriteLine(a + b);
            }
            else if (enter_key == '*')
            {
                Console.WriteLine(a * b);
            }
            else if (enter_key == '/')
           
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
                else
            {
                Console.WriteLine(a / b);
            }




            
            






        }

    }
}