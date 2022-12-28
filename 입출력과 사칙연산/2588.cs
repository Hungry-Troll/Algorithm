using System;

namespace Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int temp1 = int.Parse(ss[0]);
            int temp2 = int.Parse(ss[1]);
            int num1 = temp1 / 100;
            int num2 = (temp1 % 100) / 10;
            int num3 = (temp1 % 10);
            int num4 = temp2 / 100;
            int num5 = (temp2 % 100) / 10;
            int num6 = (temp2 % 10);

            Console.WriteLine((num1 * num6 * 100) + (num2 * num6 * 10) + (num3 * num6));
            Console.WriteLine(((num1 * num5 * 100) + (num2 * num5 * 10) + (num3 * num5)));
            Console.WriteLine(((num1 * num4 * 100) + (num2 * num4 * 10) + (num3 * num4)));
            Console.WriteLine(((num1 * num6 * 100) + (num2 * num6 * 10) + (num3 * num6)) +
                (((num1 * num5 * 100) + (num2 * num5 * 10) + (num3 * num5)) * 10) +
                (((num1 * num4 * 100) + (num2 * num4 * 10) + (num3 * num4)) * 100));
        }
    }

}
