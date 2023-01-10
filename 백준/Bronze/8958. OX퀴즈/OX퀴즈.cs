class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int count = int.Parse(s);
        string? sss = null;

        int score = 0;
        int scoreAdd = 0;
        for (int i = 0; i < count; i++)
        {
            string ss = Console.ReadLine();
            for (int j = 0; j < ss.Length; j++)
            {
                sss = ss.Substring(j, 1);
                if (sss == "O")
                {
                    score++;
                    score = score + scoreAdd;
                    scoreAdd++;
                }
                else
                {
                    scoreAdd = 0;
                }
            }
            Console.WriteLine(score);
            score -= score;
            scoreAdd -= scoreAdd;
        }
    }
}