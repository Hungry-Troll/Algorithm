using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string []ss = num.Split();
            int num1 = int.Parse(ss[0]);
            int num2 = int.Parse(ss[1]);
            int num3 = int.Parse(ss[2]);
            if(num1 == num2 && num1 == num3)
            {
                Console.WriteLine(10000 + (num1 * 1000));
            }
            else if(num1 == num2)
            {
                Console.WriteLine(1000 + (num1 * 100 ));
            }
            else if(num1 == num3)
            {
                Console.WriteLine(1000 + (num1 * 100));
            }
            else if(num2 == num3)
            {
                 Console.WriteLine(1000 + (num2 * 100));
            }
            else
            {
                if(num1 >= num2)
                {
                    if(num1 >= num3)
                    {
                        Console.WriteLine(num1 * 100);
                    }
                    else if(num3 > num1)
                    {
                        Console.WriteLine(num3 * 100);
                    }
                }
                else if(num2 > num1)
                {
                    if(num2 >= num3)
                    {
                        Console.WriteLine(num2 * 100);
                    }
                    else if(num3 > num2)
                    {
                        Console.WriteLine(num3 * 100);
                    }
                }
            }
        }
    }
}
