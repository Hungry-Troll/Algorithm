class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        int cnt = 0;
        if(ss[0] == "")
        {
            cnt--;
        }
        if(ss[ss.Length-1] == "")
        {
            cnt--;
        }
        Console.WriteLine(ss.Length + cnt);
    }
}