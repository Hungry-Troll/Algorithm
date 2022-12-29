using System;

namespace Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int numA = int.Parse(s1);
            int numB = int.Parse(s2);
            int num100 = numB / 100;
            int num10 = (numB / 10) % 10;
            int num1 = (numB) % 10;
            Console.WriteLine(numA * num1);
            Console.WriteLine(numA * num10);
            Console.WriteLine(numA * num100);
            Console.WriteLine(numA * numB);
        }
    }

}
