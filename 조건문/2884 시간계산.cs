using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = Console.ReadLine();
            string []ss = h.Split();
            int H = int.Parse(ss[0]);
            int M = int.Parse(ss[1]);
            if(M == 45)
                Console.WriteLine(H + " " + 0);
            else if (M > 45)
                Console.WriteLine(H + " " + (M - 45));
            else if (M < 45 && H != 0)
                Console.WriteLine((H - 1) +  " " + (M + 15));
            else if (M < 45 && H == 0)
                Console.WriteLine(23 + " " + (M + 15));
        }
    }
}
