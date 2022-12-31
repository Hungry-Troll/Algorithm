using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int dan = int.Parse(num);
            int count = 10;
            for (int i = 1; i < count; i++)
			{
                Console.WriteLine(dan + " * " + i + " = " + dan * i);
			}
        }
    }
}
