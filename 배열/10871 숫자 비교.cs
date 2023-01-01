using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string []ss = s.Split();
            int Count = int.Parse(ss[0]);
            int CheckCount = int.Parse(ss[1]);
            //
            string s1 = Console.ReadLine();
            string []ss2 = s1.Split();
            for (int i = 0; i < Count; i++)
            {
                int temp = int.Parse(ss2[i]);
                if (temp < CheckCount)
                {
                    Console.Write(temp + " ");
                }
            }
        }
    }
}
