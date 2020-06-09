using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task1
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
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }
            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Произведение " + a + " и " + b + " равно " + total + ".");
            }
            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine( + a + " / " + b + " равно " + total + ".");
            }
            else if (oper == '%')
            {
                total = a % b;
                Console.WriteLine("Остаток от деления " +a + " и " + b + " равен " + total + ".");
            }
            else if (oper == 'S')
            {
                total = Math.Pow(a,2) * Math.PI;
                Console.WriteLine("Площадь круга с радиусом " +a+ " равна " + total+ ".");
            }
            Console.ReadKey();

        }


    }
}
