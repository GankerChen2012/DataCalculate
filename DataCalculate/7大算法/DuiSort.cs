using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class DuiSort
    {
        /// <summary>
        /// 构建堆
        /// </summary>
        /// <param name="list">待排序集合</param>
        /// <param name="i"></param>
        /// <param name="size"></param>
        public void HeapAdjust(List<int> list, int i, int size)
        {
            int lchild = 2*i + 1;
            int rchild = 2*i + 2;
            int max = i;

            if (lchild < size && list[lchild] > list[max])
            {
                max = lchild;
            }

            if (rchild < size && list[rchild] > list[max])
            {
                max = rchild;
            }

            if (max != i)
            {
                var temp = list[i];
                list[i] = list[max];
                list[max] = temp;
                HeapAdjust(list, max, size);
            }


        }

        public void BuildHeap(List<int> list)
        {
            for (int j = list .Count/ 2 - 1; j >= 0; j--)
            {
                HeapAdjust(list, j, list.Count);
            }
        }

        public void Sort(List<int> list)
        {
            BuildHeap(list);

            for (int i = list.Count-1; i >0; i--)
            {
                var temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                HeapAdjust(list,0,i);

            }

        }

    }
}
