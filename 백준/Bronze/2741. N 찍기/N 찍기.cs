using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int num= int.Parse(s);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < num; i++)
        {
            sb.AppendLine((i + 1).ToString());
        }
        Console.WriteLine(sb.ToString());
    }
}