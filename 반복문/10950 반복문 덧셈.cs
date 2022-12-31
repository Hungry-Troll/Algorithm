using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startNum = Console.ReadLine();
            int count = int.Parse(startNum);
            for (int i = 0; i < count; i++)
			{
                string test = Console.ReadLine();
                string []num = test.Split();
                int num1 = int.Parse(num[0]);
                int num2 = int.Parse(num[1]);
                Console.WriteLine(num1 + num2);
			}
        }
    }
}
