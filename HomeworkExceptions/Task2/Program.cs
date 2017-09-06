using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 10;
            Random rand = new Random();
            int[] array = new int[index];
            for (int i = 0; i < index; i++)
            {
                array[i] = rand.Next(100);
            }
            try
            {
                Console.WriteLine(array[index+10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Конец обработки массива");
            }
            
            Console.ReadLine();
        }
    }
}
