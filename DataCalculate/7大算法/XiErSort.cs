using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class XiErSort
    {
        public void Sort(List<int> list)
        {
            var step = list.Count / 2;
            while (step >= 1)
            {
                for (int i = step; i < list.Count; i++)
                {
                    var temp = list[i];
                    int j;
                    for (j = i - step; j >= 0 && temp < list[j]; j = j - step)
                    {
                        list[j + step] = list[j];
                    }
                    list[j + step] = temp;

                }
                step = step / 2;
            }
            //Console.WriteLine("希尔1:" + string.Join(",", list));
        }


        public void Sos(List<int> list1)
        {
            var list = list1;
            var step = list.Count/2;
            while (step>=1)
            {
                for (var i = step; i < list.Count; i++)
                {
                    var temp = list[i];
                    var k = -1;
                    for (int j = i; j >= 0 && j - step >= 0 && temp < list[j - step]; j = j - step)
                    {
                        list[j] = list[j - step];
                        k = j - step;
                    }

                    if (k != -1)
                        list[k] = temp;
                }
                step = step/2;
            }
            //Console.WriteLine("希尔2:" + string.Join(",", list));
        }



    }
}
