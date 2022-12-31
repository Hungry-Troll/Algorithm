using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int point = int.Parse(s);
            if( point >= 90 && point <= 100 )
                Console.WriteLine("A");
            else if( point >= 80 && point <= 89 )
                Console.WriteLine("B");
            else if( point >= 70 && point <= 79 )
                Console.WriteLine("C");
            else if( point >= 60 && point <= 69 )
                Console.WriteLine("D");
            else if( point <= 59 )
                Console.WriteLine("F");
        }
    }
}
