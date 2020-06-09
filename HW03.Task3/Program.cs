using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int agePerson;
            int monthPerson;
            int col;
            DateTime now = DateTime.Today;
            var age = now.Year;
            var month = now.Month;

            Console.WriteLine("Введите год Вашего рождения:");
            agePerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нормер месяца Вашего рождения:");
            monthPerson = Convert.ToInt32(Console.ReadLine());

            if (monthPerson <= month)
            {
                col = age - agePerson;
                Console.WriteLine("Вам " + col + " лет");
            }
            
           else if (monthPerson > month)
            {
                col = age - agePerson - 1;
                Console.WriteLine("Вам " + col + " лет");
            }
            Console.Read();
        }
    }
}
