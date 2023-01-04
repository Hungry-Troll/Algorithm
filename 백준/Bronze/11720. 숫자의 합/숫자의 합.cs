    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int Count1 = int.Parse(s1);
            long temp = 0;
            for (int i = 0; i < Count1; i++)
            {
                string ss = s2.Substring(i,1);
                temp += int.Parse(ss);
            }
            Console.WriteLine(temp);
        }
    }