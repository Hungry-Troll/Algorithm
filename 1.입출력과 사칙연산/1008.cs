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
            Console.WriteLine(temp1 / temp2);
        }
    }

}
