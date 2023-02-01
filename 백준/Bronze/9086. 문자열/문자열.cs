class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int num = int.Parse(s);
        for (int i = 0; i < num; i++)
        {
            string ss = Console.ReadLine();
            Console.WriteLine(ss[0].ToString() + ss[^1].ToString());
        }
    }
}