class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[] ss = s.Split();
        double[] num = new double[ss.Length];
        for (int i = 0; i < ss.Length; i++)
        {
            num[i]= double.Parse(ss[i]);
        }
        Console.WriteLine(num[0] + num[1] + num[2]);
    }
}