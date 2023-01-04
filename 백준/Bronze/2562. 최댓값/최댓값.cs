  class Program
    {
        static string[] ss = new string[9];
        static int[] num = new int[9];
        static int highNum;
        static int highScore;
        static void Main(string[] args)
        {
            //9번 반복해서 숫자 저장
            for (int i = 0; i < 9; i++)
            {
                ss[i] = Console.ReadLine();
                num[i] = int.Parse(ss[i]);
            }

            // 숫자 비교
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(num[i] > num[j] && num[i] > highScore)
                    {
                        highScore = num[i];
                        highNum = i;
                    }
                }
            }

            Console.WriteLine(num[highNum]);
            Console.WriteLine(highNum + 1);
        }
    }