using System;
using System.Collections.Generic;
using System.Text;
namespace Algorithm2
{
 
        static void Main(string[] args)
        {
            // 우선 입력
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
            // 길이가 짧은 것 부터 정렬 + 중복 문자 제거
            for (int i = 0; i < tmp.Count; i++)
            {
                for (int j = 0; i < tmp.Count; j++)
                {
                    // 제거할 리스트 널 처리
                    if(tmp[i] == tmp[j])
                    {
                        tmp[i] = null;
                    }
                    // 정렬
                    if(tmp[i].Length > tmp[j].Length)
                    {
                        string tmpSS = tmp[i];
                        tmp[i] = tmp[j];
                        tmp[j] = tmpSS;
                    }
                }
            }
            // 널 중복 제거
            tmp.RemoveAll((null));
            for (int i = 0; i < tmp.Count; i++)
            {
                Console.WriteLine(tmp[i]);
            }
            

        }
    }
}
