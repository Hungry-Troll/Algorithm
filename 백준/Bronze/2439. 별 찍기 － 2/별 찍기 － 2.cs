class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int test;
        test = int.Parse(s);
        string ss = string.Empty;


        for (int i = 0; i < test; i++)
        {
            for (int j = 0; j < test - i-1; j++)
            {
                ss += " ";
            }

            for (int j = 0; j < i+1; j++)
            {
                ss += "*";
            }
            Console.WriteLine(ss);
            ss = string.Empty; 
        }
    }
}