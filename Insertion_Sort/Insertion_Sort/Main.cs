namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] list = str.Split(' ');
            int index = Int32.Parse(list[0]);
            int Count = Int32.Parse(list[1]);
            if (index >= 5 && index < 10000 && 
                Count >= 1 && Count <= (index*index))
            {
                int[] array = new int[index];
                str = Console.ReadLine();

                No24051 no24051 = new No24051();
                no24051.work(str, array, Count);
            }
        }
    }
}