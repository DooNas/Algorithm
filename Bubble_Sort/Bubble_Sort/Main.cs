using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            No23968 no23968 = new No23968();

            string str = Console.ReadLine();
            string[] list = str.Split(' ');
            int index = Int32.Parse(list[0]);
            int Count = Int32.Parse(list[1]);

            str = Console.ReadLine();
            int[] array = new int[index];
            no23968.arrayset(str, array);
            no23968.BubbleSort(array, Count);
        }
    }
}