class Program
{
    static void Main(string[] args)
    {

        string s = Console.ReadLine();
        int count= int.Parse(s);
        string ss = Console.ReadLine();
        string[] tmp = ss.Split();
        int[] num = new int[count];

        for (int i = 0; i < count; i++)
        {
            num[i] = int.Parse(tmp[i]);
        }
        // 최소 최대 값 변수
        int bigNum = num[0];
        int smallNum = num[0];

        for (int i = 0; i < count; i++)
        {
            if (bigNum < num[i])
                bigNum = num[i];
            if (smallNum > num[i])
                smallNum = num[i];
        }
        Console.WriteLine(smallNum + " " + bigNum);
        
    }
}