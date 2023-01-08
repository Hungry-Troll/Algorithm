using System;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        byte []tmp = Encoding.ASCII.GetBytes(s);
        Console.WriteLine(tmp[0]);
    }
}