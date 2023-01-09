class Program
{
    static void Main(string[] args)
    {
        DateTime day = DateTime.Today;
        Console.WriteLine("{0}-{1:D2}-{2:D2}",day.Year,day.Month,day.Day);
    }
}