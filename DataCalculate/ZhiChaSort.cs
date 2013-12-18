using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class ZhiChaSort
    {

        public void Sort1(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var temp = list[i];
                int j;

                for (j = i - 1; j >= 0 && temp < list[j]; j--)
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = temp;
            }
        }

        public void Sort2(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var temp = list[i];
                var k = -1;
                for (var j = i; j >= 1 && temp < list[j - 1]; j--)
                {
                    list[j] = list[j - 1];
                    k = j - 1;
                }
                if (k != -1)
                    list[k] = temp;
            }
            Console.WriteLine("直插2:" + string.Join(",", list));
        }


    }
}
