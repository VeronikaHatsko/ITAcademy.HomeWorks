using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Сумма введенных чисел равна " + Sum() + ".");
                Console.Read();
        }
            static int Sum()
            {
                int x;
                int y;
                int total;
                Console.WriteLine("Введите первое слагаемое");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Введите второе слагаемое");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                total = x + y;
                return total;
            
            }
    }
}
