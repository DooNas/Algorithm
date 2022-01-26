using System;
using System.Runtime.InteropServices;

namespace baekjoon
{

    public class No24051
    {
        private string str = null;
        private string[] list = null;
        private int index;
        private int Count;
        private int[] array;
        private int Temp = -1;

        public void arrayset(String numbers, int[] array)
        {
            string[] numberlist = numbers.Split(' ');
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Int32.Parse(numberlist[index]);
            }
        }

        public void work()
        {
            str = Console.ReadLine();
            list = str.Split(' ');
            index = Int32.Parse(list[0]);
            Count = Int32.Parse(list[1]);

            array = new int[index];
            str = Console.ReadLine();
            arrayset(str, array);
            Insertion_sort();
            Printmsg();
        }

        public void Insertion_sort()
        {
            int index = 0;
            int jndex = 0;
            int key = 0;

            int nCount = 0;

            for (index = 1; index < array.Length; index++)  // 기준이 될 키를 선정 두번째부터 끝까지
            {
                key = array[index];
                for (jndex = index - 1; jndex >= 0 && array[jndex] > key; jndex--)
                {
                    array[jndex + 1] = array[jndex];
                    if (nCount == Count)
                    {
                        Temp = array[jndex + 1];
                    }
                    nCount++;
                }
                array[jndex + 1] = key;
                if (nCount == Count)
                {
                    Temp = key;
                }
                nCount++;
            }
        }
        public void Printmsg()
        {
            Console.Write(Temp);
        }
    }
}
