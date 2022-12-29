using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int num = int.Parse(s1);
            int count = 0;
            while(num > count)
            {
                count++;
                Count(count);
            }
        }
        static void Count(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
