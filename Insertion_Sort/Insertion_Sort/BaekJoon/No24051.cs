using System;

namespace baekjoon
{

    public class No24051
    {
        private string str = null;
        private string[] list = null;
        private int index;
        private int Count;
        private int[] array;

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
        }

        public void Insertion_sort()
        {
            int index = 0;
            int jndex = 0;
            int key = 0;
            for (index = 1; index < array.Length; index++)  // 기준이 될 키를 선정 두번째부터 끝까지
            {
                key = array[index];
                for (jndex = index - 1; jndex >= 0 && array[jndex] > key; jndex--)  // 키값을 기준으로 내림차순으로 비교한다. + 키값보다 큰 상테일 동안 진행
                {
                    array[jndex + 1] = array[jndex];
                }
                array[jndex + 1] = key;
            }

            foreach (int n in array)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
