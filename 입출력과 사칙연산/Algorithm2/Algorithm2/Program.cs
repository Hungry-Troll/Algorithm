using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp1 = Console.ReadLine();
            int count = int.Parse(tmp1);
            string tmp2 = Console.ReadLine();
            int num = int.Parse(tmp2);
            int sum = 0;
            int cnt = 0;
            for (int i = 0; i <  count; i++)
			{
                if (cnt == 0)
                {
                    sum += ((int)num / (int)Math.Pow(10, count - (i - 2)));
                    cnt++;
                }
                else
                {
                    sum += ((int)num / (int)Math.Pow(10, count - (i - 2))) % 10;
                }
                //5자리의 경우
                //Console.WriteLine((int)num / (int)Math.Pow(10, count i- 2));
                //4자리의 경우
                //Console.WriteLine((int)num / (int)Math.Pow(10, count - 3)) % 10;
                //3자리의 경우
                //Console.WriteLine((int)num / (int)Math.Pow(10, count - 4)) % 10;
                //2자리의 경우
                //Console.WriteLine((int)num / (int)Math.Pow(10, count - 5)) % 10;
                //자리의 경우
                //Console.WriteLine((int)num / 10) % 10;

                //if(count - i == 2)
                //{
                  //  sum += (int)((num / 10) % 10);
                //}
                //if(count - i == 1)
                //{
                  //  sum += (int)(num % 10);
                //}
			}
            Console.WriteLine(sum);
        }
    }
}
