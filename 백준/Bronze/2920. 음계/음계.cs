class Program
{
    static void Main(string[] args)
    {
        string s;
        int[] num = new int[8];
        int[] ascending = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] descending = { 8, 7, 6, 5, 4, 3, 2, 1 };

        // 확인을 위한 int 카운트 변수
        int _as = 0;
        int _ds = 0;
        int _mx = 0;
        s = Console.ReadLine();
        string[] ss = s.Split();
        // 대입
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToInt32(ss[i]);
        }
        // ascending 비교
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == ascending[i])
                _as++;
            if (num[i] == descending[i])
                _ds++;
        }
        if(_as == ascending.Length)
            Console.WriteLine("ascending");
        else if(_ds == descending.Length)
            Console.WriteLine("descending");
        else
            Console.WriteLine("mixed ");
    }
}