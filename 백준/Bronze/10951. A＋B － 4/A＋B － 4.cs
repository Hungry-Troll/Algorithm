using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (s == null)
                break;
            string[] ss = s.Split(' ');
            Console.WriteLine(int.Parse(ss[0]) + int.Parse(ss[1]));
        }
    }
}