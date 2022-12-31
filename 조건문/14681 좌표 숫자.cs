using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            int Xpos = int.Parse(x);
            int Ypos = int.Parse(y);
            if(Xpos > 0 && Ypos > 0)
                Console.Write(1);
            else if( Xpos < 0 && Ypos > 0)
                Console.Write(2);
            else if( Xpos > 0 && Ypos < 0)
                Console.Write(4);
            else if( Xpos < 0 && Ypos < 0)
                Console.Write(3);
        }
    }
}
