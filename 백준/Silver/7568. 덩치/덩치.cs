 public struct Dungch
    {
        public int height;
        public int weight;
        public int Cnt;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int Count1 = int.Parse(s1);
            Dungch[] DUNGCH = new Dungch[Count1];
            // 덩치를 배열에 넣음
            for (int i = 0; i < Count1; i++)
            {
               string temp = Console.ReadLine();
               string []value = temp.Split();
               DUNGCH[i].weight = int.Parse(value[0]);
               DUNGCH[i].height = int.Parse(value[1]);
            }
            // 덩치 비교
            for (int i = 0; i < Count1; i++)
            {
                for (int j = 0; j < Count1; j++)
                {
                    if (DUNGCH[i].weight < DUNGCH[j].weight && DUNGCH[i].height < DUNGCH[j].height)
                    {
                        // i가 j보다 덩치가 작다는것
                        DUNGCH[i].Cnt++;
                    }
                }
            }
            // 출력
            for (int i = 0; i < Count1; i++)
            {
                Console.Write((DUNGCH[i].Cnt +1)  + " ");
            }
        }
    }