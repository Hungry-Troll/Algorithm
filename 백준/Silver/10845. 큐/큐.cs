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