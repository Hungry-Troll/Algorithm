using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int point = int.Parse(s);
            if( point % 4 == 0 && point % 100 != 0 )
                Console.Write(1);
            else if( point % 4 == 0 && point % 400 == 0 )
                Console.Write(1);
            else
                Console.Write(0);
        }
    }
}
