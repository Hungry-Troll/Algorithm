using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


class Program
{
    static string[,] score =
    {
        {"A+","A0","A-"},
        {"B+","B0","B-"},
        {"C+","C0","C-"},
        {"D+","D0","D-"},
        {"F","01","02" }
    };

    static float[,] num =
    {
        {4.3f,4.0f,3.7f},
        {3.3f,3.0f,2.7f},
        {2.3f,2.0f,1.7f},
        {1.3f,1.0f,0.7f},
        {0.0f,0.0f,0.0f},
    };

    static void Main(string[] args)
    {
        Dictionary<string, float> dic = new Dictionary<string, float>();

        for (int i = 0; i < score.GetLength(0); i++)
        {
            for (int j = 0; j < score.GetLength(1); j++)
            {
                dic.Add(score[i, j], num[i, j]);
            }
        }

        string s = Console.ReadLine();
        if (dic.ContainsKey(s))
        {
            Console.WriteLine("{0:F1}", dic[s]);
        }
    }
}