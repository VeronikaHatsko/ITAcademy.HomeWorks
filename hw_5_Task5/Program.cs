using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i','j', 'k'
                    ,'l','m', 'n', 'o', 'p', 'q', 'r', 's', 't','u', 'v','w' , 'x', 'y', 'z'};
            for (int i = letters.Length - 1; i >= 0; i--)
                Console.Write(letters[i] + " ");
            Console.Read();
        }
    }
}
