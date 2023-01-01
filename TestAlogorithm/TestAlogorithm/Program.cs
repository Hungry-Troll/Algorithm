using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int TestCount = int.Parse(s);
            string ss = Console.ReadLine();
            string[] TestPoint = ss.Split();
            // 가장 큰 점수를 찾는다
            int HighScore = 0;
            // 어차피 찾으면서 배열에 점수를 넣기
            int[] tmpPoint = new int[TestCount];
            // 찾은 점수 계산용 배열
            float[] SumPoint = new float[TestCount];
            // 최종 함산 점수 변수
            float SumScore = 0.0f;
            for (int i = 0; i < TestCount; i++)
            {
                int tmp = int.Parse(TestPoint[i]);
                tmpPoint[i] = tmp;
                if (HighScore < tmp)
                    HighScore = tmp;
            }
            // 점수 계산
            for (int i = 0; i < TestCount; i++)
            {
                SumPoint[i] = (float)tmpPoint[i] / HighScore;
                SumScore += SumPoint[i];
            }
            // 최종 계산
            float FinalScore = ((SumScore / TestCount) * 100);
            Console.WriteLine(FinalScore);
        }
    }
}
