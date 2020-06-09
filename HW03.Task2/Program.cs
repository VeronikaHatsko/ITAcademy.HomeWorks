using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double c;
            double total;
            char oper;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какую опереацию хотите выполнить? + - * / % S ");
            oper = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if (oper == '+')
            {
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + Sums(a, b) + ".");
            }
            else if (oper == '-')
            {
                Console.WriteLine("Разность " + a + " и " + b + " равна " + Diff(a, b) + ".");
            }
            else if (oper == '*')
            {
                Console.WriteLine("Произведение " + a + " и " + b + " равно " + Prod(a, b) + ".");
            }
            else if (oper == '/')
            {
                Console.WriteLine(+a + " / " + b + " равно " + Part(a, b) + ".");
            }
            else if (oper == '%')
            {
                Console.WriteLine("Остаток от деления " + a + " и " + b + " равен " + RemOfDiv(a, b) + ".");
            }
            else if (oper == 'S')
            {
                Console.WriteLine("Площадь круга с радиусом " + a + " равна " + AreaOfCircle(a) + ".");
            }
            Console.Read();
        }

        static int Sums(int x, int y)
        {
            return x + y;
        }

        static int Diff(int x, int y)
        {
            return x - y;
        }

        static int Prod(int x, int y)
        {
            return x * y;
        }

        static double Part(int x, int y)
        {
            return x / y;
        }

        static double RemOfDiv(int x, int y)
        {
            return x % y;
        }

        static double AreaOfCircle(int x)
        {
            return Math.Pow(x, 2) * Math.PI;
        }
    }
}
