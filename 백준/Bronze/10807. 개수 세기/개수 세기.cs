class Program
{
    static void Main(string[] args)
    {

        string s = Console.ReadLine();
        int num = int.Parse(s);
        string ss = Console.ReadLine();
        string []strArr = ss.Split();
        string sss = Console.ReadLine();
        int num2 = int.Parse(sss);
        int cnt = 0;
        for (int i = 0; i < num; i++)
        {
            int temp = int.Parse(strArr[i]);
            if(temp == num2)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }
}