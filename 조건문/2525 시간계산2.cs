using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string now = Console.ReadLine();
            string timer = Console.ReadLine();
            string []ss = now.Split();
            int H = int.Parse(ss[0]);
            int M = int.Parse(ss[1]);
            int D = int.Parse(timer);
            int LM;
            if(M + D < 60)
                Console.WriteLine(H + " " + (M + D));
            if (M + D >= 60)
            {
                int count = (M + D) / 60;
                H = H + count; 
                LM = (( M+D ) % 60);
                if(H == 24)
                    Console.WriteLine(0 + " " + LM);
                else if(H > 24)
                    Console.WriteLine(H % 24 + " " + LM);
                else
                    Console.WriteLine(H + " " + LM);
            }
        }
    }
}
