using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        string s = Console.ReadLine();
        int cnt = int.Parse(s);
        int lastNum = int.MaxValue;

        StringBuilder sb = new StringBuilder();

        //sb.AppendLine(i.ToString());
        
        Console.Write(sb.ToString());

        for (int i = 0; i < cnt; i++)
        {
            string ss = Console.ReadLine();
            if(ss.Contains("push"))
            {
                string[]sss = ss.Split();
                int num = int.Parse(sss[1]);
                Push(num);
            }
            else if (ss.Contains("pop"))
            {
                Pop();
            }
            else if (ss.Contains("size"))
            {
                Size();
            }
            else if (ss.Contains("empty"))
            {
                Empty();
            }
            else if (ss.Contains("front"))
            {
                Front();
            }
            else if (ss.Contains("back"))
            {
                Back();
            }
        }

        //string str = sb.ToString();
        //string []sArray = str.Split();
        //for (int i = 0; i < sArray.Length; i++)
        //{
            Console.WriteLine(sb.ToString());
        //}

        void Push(int num)
        {
            q.Enqueue(num);
            lastNum = num;
        }
        void Pop()
        {
            if (q.Count == 0)
            {
                //Console.WriteLine(-1);
                sb.AppendLine("-1");
                //sb.AppendLine(" ");
            }
            else
            {
                //Console.WriteLine(q.Dequeue());
                sb.AppendLine((q.Dequeue()).ToString());
                //sb.AppendLine(" ");
            }

        }
        void Size()
        {
            //Console.WriteLine(q.Count);
            sb.AppendLine((q.Count).ToString());
            //sb.AppendLine(" ");
        }
        void Empty()
        {
            if(q.Count == 0)
            {
                //Console.WriteLine(1);
                sb.AppendLine("1");
                //sb.AppendLine(" ");
            }
            else
            {
                //Console.WriteLine(0);
                sb.AppendLine("0");
                //sb.AppendLine(" ");
            }
                
        }
        void Front()
        {
            if (q.Count == 0)
            {
                //Console.WriteLine(-1);
                sb.AppendLine("-1");
                //sb.AppendLine(" ");
            }
                
            else
            {
                //Console.WriteLine(q.Peek());
                sb.AppendLine((q.Peek().ToString()));
                //sb.AppendLine(" ");
            }
                
        }
        void Back()
        {
            if (q.Count == 0)
            {
                //Console.WriteLine(-1);
                sb.AppendLine("-1");
                //sb.AppendLine(" ");
            }
                
            else
            {
                //Console.WriteLine(lastNum);
                sb.AppendLine(lastNum.ToString());
                //sb.AppendLine(" ");
            }
                
        }
    }
}

/*// 우선 입력
List<string> tmp = new List<string>();
// 제거할 대상 저장 리스트
List<string> deletList = new List<string>();
string s = Console.ReadLine();
int num = int.Parse(s);
for (int i = 0; i < num; i++)
{
    string ss = Console.ReadLine();
    tmp.Add(ss);
}
// 문자열 정렬
string[] sortArray = sortArray = tmp.OrderBy(n => n).ToArray();
// 정렬된 배열 리스트로 대입
for (int i = 0; i < sortArray.Length; i++)
{
    tmp[i] = sortArray[i];
}
// 길이가 짧은 것 부터 정렬 + 중복 문자 제거
for (int i = 0; i < tmp.Count; i++)
{
    for (int j = 0; j < tmp.Count; j++)
    {
        // 자릿수 정렬
        if (tmp[i].Length < tmp[j].Length)
        {
            string tmpSS = tmp[i];
            tmp[i] = tmp[j];
            tmp[j] = tmpSS;
        }
    }
}
for (int i = 0; i < tmp.Count; i++)
{
    for (int j = 0; j < tmp.Count; j++)
    {
        // 중복제거
        if (tmp[i] == tmp[j] && i != j)
        {
            tmp.RemoveAt(j);
            j--;
        }
    }
}
for (int i = 0; i < tmp.Count; i++)
{
    Console.WriteLine(tmp[i]);
}
*/
