using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, total, p;
            char zn;
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите + для суммы");
            Console.WriteLine("Введите - для разности");
            zn = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if (zn == '+')
            {
                Console.WriteLine("Вы выбрали операцию сложения");
                total = x + y;
                Console.WriteLine("Каков результат сложения, по - вашему?");
                p = Convert.ToInt32(Console.ReadLine());
                if (p > total)
                {
                    Console.WriteLine("Неправильно! Должно быть меньше");
                }
                else if (p < total)
                {
                    Console.WriteLine("Неправильно! Должно быть больше");
                }
                else if (p == total)
                {
                    Console.WriteLine("Верно! Сумма " + x + " и " + y + " равна " + total + ".");
                }
            }
            if (zn == '-')
            {
                Console.WriteLine("Вы выбрали операцию вычитания");
                total = x - y;
                Console.WriteLine("Каков результат вычитатания, по - вашему?");
                p = Convert.ToInt32(Console.ReadLine());
                if (p > total)
                {
                    Console.WriteLine("Неправильно! Должно быть меньше");
                }
                else if (p < total)
                {
                    Console.WriteLine("Неправильно! Должно быть больше");
                }
                else if (p == total)
                {
                    Console.WriteLine("Верно! Сумма " + x + " и " + y + " равна " + total + ".");
                }
            }
            Console.Read();
        }
    }
}
