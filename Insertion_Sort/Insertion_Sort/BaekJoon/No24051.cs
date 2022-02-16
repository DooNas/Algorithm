namespace baekjoon
{

    public class No24051
    {
        public void work(string str, int[] array, int count)
        {
            arrayset(str, array);
            Insertion_sort(array, count);
        }
        public void arrayset(String numbers, int[] array)
        {
            string[] numberlist = numbers.Split(' ');
            for (int index = 0; index < array.Length; index++)
            { 
                array[index] = Int32.Parse(numberlist[index]);
            }
        }
        public void Insertion_sort(int[] array, int count)
        {
            int jndex = 0;
            int key = 0;

            int nCount = 0;
            int Temp = -1;

            for (int index = 1; index < array.Length; index++)  // 기준이 될 키를 선정 두번째부터 끝까지
            {
                key = array[index];
                for (jndex = index - 1; jndex >= 0 && array[jndex] > key; jndex--)
                {
                    array[jndex + 1] = array[jndex];
                    if (nCount == count)
                    {
                        Temp = array[jndex + 1];
                    }
                    nCount++;
                }
                array[jndex + 1] = key;
                if (nCount == count)
                {
                    Temp = key;
                }
                nCount++;
            }
            nCount--;
            Console.WriteLine(Temp);
        }
    }
}
