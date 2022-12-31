using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startNum = Console.ReadLine();
            int count = int.Parse(startNum);
            int sum = 0;
            for (int i = 0; i < count; i++)
			{
                sum = i + 1 + sum;
			}
            Console.WriteLine(sum);
        }
    }
}
