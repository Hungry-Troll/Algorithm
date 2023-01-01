using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string [] ss = s.Split();
            int num1 = int.Parse(ss[0]);
            int num2 = int.Parse(ss[1]);
            if(num1 > num2)
                Console.WriteLine(">");
            else if(num1 < num2)
                Console.WriteLine("<");
            else if(num1 == num2)
                Console.WriteLine("==");
        }
    }
}
