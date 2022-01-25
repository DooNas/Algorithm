using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon
{
    public class No23969
    {
        public void arrayset(String numbers, int[] array)
        {
            string[] numberlist = numbers.Split(' ');
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Int32.Parse(numberlist[index]);
            }
        }
        public void BubbleSort(int[] array, int Count)
        {
            bool swap = true;
            int nCount = 0;
            bool over = true;

            int[] list = new int[array.Length];

            while (swap)
            {
                swap = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        swap = true;
                        int temp = 0;
                        temp = array[index];
                        array[index] = array[index+1];
                        array[index+1] = temp;
                        nCount++;
                        if (nCount == Count)
                        {
                            over = false;
                            for (int endex = 0; endex < array.Length; ++endex)
                            {
                                list[endex] = array[endex];
                            }
                        }
                    }
                }
            }
            if (over)
            {
                Console.WriteLine(-1);
            }
            else
            {
                foreach (int n in list)
                {
                    Console.Write("{0} ", n);
                }
            }
        }
    }
}
