using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class KmpCalculate
    {
        public KmpCalculate()
        {
            string str = "acacacaba";
            string kmpStr = "acaaba";

            Kmp(str,kmpStr);

        }

        private void Kmp(string str, string kmpStr)
        {
            char[] strChs = str.ToCharArray();
            char[] kmpStrChs = kmpStr.ToCharArray();
            int[] next=new int[kmpStrChs.Length];

            GetNextVal(kmpStrChs, next);

            int i = 0;//主串
            int pos = 0;//匹配到了多少到字符
            while (i < strChs.Length && pos<kmpStrChs.Length)
            {
                if (strChs[i] == kmpStrChs[pos])
                {
                    i++;
                    pos++;
                }
                else
                {
                    pos = next[pos];

                    if (pos == -1)
                    {
                        pos++;
                        i++;
                    }
                }

                if (pos == kmpStrChs.Length)
                {
                    Console.WriteLine("匹配成功:第" + i + "个位置");
                    break;
                }
            }


        }

        private void GetNextVal(char[] kmp, int[] next)
        {
            int i = 2;
            int j = 0;
            next[1] = 0;
            next[0] = -1;
            while (i < kmp.Length)
            {
                if (kmp[i - 1] == kmp[j])
                {
                    next[i++] = ++j;
                }
                else
                {
                    j = next[j];
                    if (j == -1)
                    {
                        next[i++] = ++j;
                    }
                }




                //if (j==0 || kmp[i] == kmp[j])
                //{
                //    ++i;
                //    ++j;

                //    if(i>=kmp.Length)
                //        break;

                //    if (kmp[i] != kmp[j])
                //        next[i] = j;
                //    else
                //        next[i] = next[j];
                //}
                //else
                //{
                //    j = next[j];
                //    if (j == -1)
                //    {
                //        ++j;
                //        i++;
                //    }
                //}
            }
        }

    }




}
