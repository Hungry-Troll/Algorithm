class Program
{
    static void Main(string[] args)
    {
        int cntLoop = 28;
        int[] students = new int[cntLoop];
        int?[] total = new int?[30];
        int result1 = int.MaxValue;
        int result2 = int.MaxValue;
        // 배열에 대입
        for (int i = 0; i < total.Length; i++)
        {
            total[i] = i + 1;
        }
        // 학생수 출석 부름
        for (int i = 0; i < cntLoop; i++)
        {
            string s = Console.ReadLine();
            int num = Convert.ToInt32(s);
            students[i] = num;
        }
        // 검사
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 0; j < total.Length; j++)
            {
                if (students[i] == total[j])
                    total[j] = null;
            }
        }

        for (int i = 0; i < total.Length; i++)
        {
            if (total[i] != null)
            {
                if (result1 == int.MaxValue)
                    result1 = (int)total[i];
                else if (result2 == int.MaxValue)
                    result2 = (int)total[i];
            }    
        }

        if (result1 > result2)
        {
            int tmp = result1;
            result2 = result1;
            result1 = tmp;
        }

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}