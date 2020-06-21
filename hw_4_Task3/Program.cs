using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, total, p;
            Console.WriteLine("Введите первое слагаемое");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите второе слагаемое");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Каков результат сложения, по - вашему?");
            p = Convert.ToInt32(Console.ReadLine());
            total = x + y;
            if (p > total)
            {
                Console.WriteLine("Перебор! Правильный ответ меньше");
            }
            else if (p < total)
            {
                Console.WriteLine("Маловато! Правильный ответ больше");
            }
            else if (p == total)
            {
                Console.WriteLine("Верно! Сумма " + x + " и " + y + " равна " + total + ".");
            }
            Console.Read();
        }
    }
}
