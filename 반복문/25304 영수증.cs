using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string costSum = Console.ReadLine();
            string count = Console.ReadLine();
            int costSumInt = int.Parse(costSum);
            int costCount = int.Parse(count);
            int sum = 0;
            for (int i = 0; i < costCount; i++)
			{
                string temp = Console.ReadLine();
                string []temp1 = temp.Split();
                int num1 = int.Parse(temp1[0]);
                int num2 = int.Parse(temp1[1]);
                sum = sum + (num1 * num2);
			}
            
            if(costSumInt == sum)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
