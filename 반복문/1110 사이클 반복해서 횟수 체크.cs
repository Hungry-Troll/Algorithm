using System;
using System.Text;
namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            //처음 숫자를 저장해야됨
            int firstCount = int.Parse(tmp);
            // 먼저 주어진 수가 10보다 작으면 곱하기 10
            if (firstCount < 10)
                firstCount = firstCount * 10;
            int loopCnt = 1;
            int nextTempCount = 0;
            while (true)
            {
                if (loopCnt == 1)
                    nextTempCount = firstCount;

                //저장된 숫자에서 각 자리수를 가지고 와야됨
                int leftCount = (nextTempCount / 10) % 10;
                int rightCount = (nextTempCount % 10);

                int sumCount = leftCount + rightCount;
                // newCount가 10보다 크거나 같으면 1자리수를 가지고 와야됨
                if (sumCount >= 10)
                    sumCount = sumCount % 10;
                //
                int nextCount = (rightCount*10) + sumCount;

                if(firstCount == nextCount)
                {
                    Console.WriteLine(loopCnt);
                    break;
                }
                loopCnt++;
                nextTempCount = nextCount;
            }
        }
    }
}
