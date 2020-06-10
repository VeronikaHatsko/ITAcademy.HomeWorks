using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов создать в массиве?");
            int raz = Convert.ToInt32(Console.ReadLine());
            int[] arrMan = new int[raz];
            int[] arrRand = new int[raz];
            int[] arrSum = new int[raz];
            for (int i = 0; i < raz; i++)
            {
                Console.WriteLine("Введите элемент массива");
                arrMan[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Вот ваш массив");
            for (int i = 0; i < raz; i++)
            {
                Console.Write("{0}\t", arrMan[i]);
            }
            Random r = new Random();
            for (int i = 0; i < raz; i++)
            {
                arrRand[i] = r.Next(500);
            }
         
            Console.WriteLine("\nЭто рандомный массив");
            for (int i = 0; i < raz; i++)
            {
                Console.Write("{0}\t", arrRand[i]);
            }
            Console.WriteLine("\nСумма элементов массивов");
            for (int i = 0; i < raz; i++)
            {
                arrSum[i] = arrMan[i] + arrRand[i];
            }
            for (int i = 0; i < raz; i++)
            {
                Console.Write("{0}\t", arrSum[i]);
            }



            Console.Read();
        }
    }
}
