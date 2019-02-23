using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_module08
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);
            Console.Write("Первый массив: ");
            Console.WriteLine(array[0] = 1);
            Console.Write("Второй массив: ");
            Console.WriteLine(array[1] = 3);
            Console.Write("Третий массив: ");
            Console.WriteLine(array[2] = 5);
            Console.WriteLine("Возведение в степень этих массивов");
            Console.Write("1. ");
            Console.Write("\n2. ");

            for (int i = 0; i < array.Size; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
