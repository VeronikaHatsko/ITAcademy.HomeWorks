using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
             //Reverse массива из задачи 3 так же реализован тут 

            Console.WriteLine("Сколько элементов создать в массиве?");
            int raz = Convert.ToInt32(Console.ReadLine());
            int[] arrMan = new int[raz];
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
            Console.WriteLine("\nВведите еще один элемент");
            int dob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В какую позицию вставить элемент?");
            int poz = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Insert(ref arrMan, dob, poz);

            Console.Read();
        }
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
            Console.WriteLine("Вот новый массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }
            
           int[] revArr = newArray;
            Array.Reverse(newArray);
            Console.WriteLine("\nМассив после реверса");
            for (int i = 0; i < revArr.Length; i++)
            {
                Console.Write("{0}\t", revArr[i]);
            }
        }
    }
}
