class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = string.Empty;
        foreach (char one in s)
        {
            result += char.IsUpper(one) ? char.ToLower(one) : char.ToUpper(one);
        }
        Console.WriteLine(result);
    }
}