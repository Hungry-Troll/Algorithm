class Program
{
    static long result;
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[]ss = s.Split();
        long a = Convert.ToInt32(ss[0]);
        long b = Convert.ToInt32(ss[1]);
        result = Calcul(a, b);
        Console.WriteLine(result);
    }

    static long Calcul(long a, long b)
    {
        return result = (a + b) * (a - b);
    }
}