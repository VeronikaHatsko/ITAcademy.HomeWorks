using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перемещаем фигуру");

            Console.WriteLine("w - переместить вверх");
            Console.WriteLine("s - переместить вниз");
            Console.WriteLine("d - переместить вправо");
            Console.WriteLine("a - переместить влево");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "w":
                    Console.Clear();
                    Console.WriteLine("Фигура переместилась вверх");
                    break;
                case "s":
                    Console.Clear();
                    Console.WriteLine("Фигура переместилась вниз");
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine("Фигура переместилась вправо");
                    break;
                case "a":
                    Console.Clear();
                    Console.WriteLine("Фигура переместилась влево");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Фигура не двигается!");
                    break;
            }


            Console.Read();
        }
    }
}
