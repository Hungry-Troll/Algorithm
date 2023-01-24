class Program
{
    static int result;
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[]ss = s.Split();
        int a = Convert.ToInt32(ss[0]);
        int b = Convert.ToInt32(ss[1]);
        result = Calcul(a, b);
        Console.WriteLine(result);
    }

    static int Calcul(int a, int b)
    {
        return result = (a + b) * (a - b);
    }
}