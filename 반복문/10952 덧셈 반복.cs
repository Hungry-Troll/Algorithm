using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string tmp = Console.ReadLine();
                string []ss = tmp.Split();
                int count1 = int.Parse(ss[0]);
                int count2 = int.Parse(ss[1]);
                if (count1 == 0 && count2 == 0)
                    break;
                Console.WriteLine(count1 + count2);
            }
        }
    }
}
