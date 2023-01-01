using System;

namespace Algorithm1
{
    class Program
    {
        static int[] num = new int[6];

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            for (int i = 0; i < ss.Length; i++)
            {
                num[i] = int.Parse(ss[i]);
            }

            Console.WriteLine((1 - num[0]) + " " + (1 - num[1]) + " " + (2 - num[2]) + " " + (2 - num[3]) + " " +
                (2 - num[4]) + " " + (8 - num[5]));
        }
    }
}
