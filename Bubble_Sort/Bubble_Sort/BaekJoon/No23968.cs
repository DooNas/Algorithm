using System;

namespace baekjoon
{
    public class No23968
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
            int temp = 0;
            int nCount = 0;
            int andex = 0;
            int bndex = 0;
            while (swap)
            {
                swap = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        swap = true;
                        temp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = temp;
                        nCount++;
                        if (nCount == Count)
                        {
                            andex = array[index];
                            bndex = array[index + 1];
                        }
                    }
                }
            }

            if (andex == 0 && bndex == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine("{0} {1}", andex, bndex);
            }
        }
    }

}