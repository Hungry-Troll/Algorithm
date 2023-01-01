using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string []ss = s.Split();
            int cnt = 5;
            int[] arry = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                int tmp = int.Parse(ss[i]);
                arry[i] = (int)Math.Pow(tmp, 2);
            }
            int num = Calcul1();
            Console.WriteLine(num);

            int Calcul1()
            {
                int tmp = 0;
                int returnNum = 0;
                for (int i = 0; i < cnt; i++)
                {
                    tmp += arry[i];
                }
                returnNum = tmp % 10;
                return returnNum;
            }
        }
    }
}
