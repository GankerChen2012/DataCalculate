using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class ZhiXuanSort
    {

        public void Sort1(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var min = list[i];
                var k = i;
                for (int j = i; j < list.Count; j++)
                {
                    if (min > list[j])
                    {
                        min = list[j];
                        k = j;
                    }
                }
                if (k != i)
                {
                    var temp = list[i];
                    list[i] = list[k];
                    list[k] = temp;
                }
            }
        }

        public void Sort2(List<int> list, int num)
        {
            if (num == list.Count - 1)
                return;

            var min = list[num];
            var j = -1;
            for (var i = num; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                    j = i;
                }
            }
            if (j != -1)
            {
                var temp = list[num];
                list[num] = list[j];
                list[j] = temp;
            }
            num++;
            Sort2(list, num);
        }

    }
}
