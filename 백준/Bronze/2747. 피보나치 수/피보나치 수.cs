    class Program
    {
        static int temp;
        static void Main(string[] args)
        {
            
            string s = Console.ReadLine();
            int tmpeNum = int.Parse(s);
            temp = 0;
            temp = fibonacci2(tmpeNum);
            Console.WriteLine(temp);
        }

/*        static int fibonacci(int num)
        {
            if (num <= 1)
                return num;

            else 
                return fibonacci(num - 1) + fibonacci(num - 2);
        }*/

        static int fibonacci2(int num)
        {
            if (num <= 1)
                return num;

            int A = 0;
            int B = 1;
            int result = 0;
            for (int i = 1; i < num; i++)
            {
                result = A + B;
                A = B;
                B = result;
            }
            return result;
        }
    }