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

            int[] array = new int[index];
            str = Console.ReadLine();

            No24051 no24051 = new No24051();
            no24051.work(str, array, Count);
        }
    }
}