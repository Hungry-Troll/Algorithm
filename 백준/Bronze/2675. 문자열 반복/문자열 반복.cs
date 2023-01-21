class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int test = int.Parse(s);
        for (int i = 0; i < test; i++)
        {
            string ss = Console.ReadLine();
            // 공백제거
            ss.Trim();
            string[] sss = ss.Split();
            int num = Convert.ToInt32(sss[0]);
            char[] chArray = sss[1].ToCharArray();
            
            for (int j = 0; j < chArray.Length; j++)
            {
                for (int k = 0; k < num; k++)
                {
                    Console.Write(chArray[j]);
                }
            }
            Console.WriteLine();
        }
    }
}