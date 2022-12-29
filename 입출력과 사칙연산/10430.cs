using System;

namespace Algorithm1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int A = int.Parse(ss[0]);
            int B = int.Parse(ss[1]);
            int C = int.Parse(ss[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }

}
