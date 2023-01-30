using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 입력
        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        // 입력값변환
        int N;
        int M;

        N = int.Parse(ss[0]);
        M = int.Parse(ss[1]);
        // 배열
        int[,] Array1 = new int[N,M];
        int[,] Array2 = new int[N,M];
        int[,] resultArr = new int[N, M];

        Array(ref Array1, N, M);
        Array(ref Array2, N, M);
        SumArray(ref Array1, ref Array2, ref resultArr, N, M);
    }

    static void Array(ref int[,] arry1, int N, int M)
    {
        for (int i = 0; i < N; i++)
        {
            string str = Console.ReadLine();
            string[] sss = str.Split(' ');
            for (int j = 0; j < M; j++)
            {
                arry1[i, j] = int.Parse(sss[j]);
            }
        }
    }

    static void SumArray(ref int[,] arry1, ref int[,] arry2, ref int[,] resultArr,int N, int M)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                resultArr[i,j] = arry1[i, j] + arry2[i, j];
                Console.Write(resultArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}