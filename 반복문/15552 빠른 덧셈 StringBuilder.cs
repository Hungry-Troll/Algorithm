using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            string sb = Console.ReadLine();
            int count = int.Parse(sb);
            for (int i = 0; i < count; i++)
			{
                string tmp = Console.ReadLine();
                string []temp1 = tmp.Split();
                int num1 = int.Parse(temp1[0]);
                int num2 = int.Parse(temp1[1]);
                sb1.Append(num1 + num2 + "\n");
			}
            Console.WriteLine(sb1.ToString());
        }
    }
}
