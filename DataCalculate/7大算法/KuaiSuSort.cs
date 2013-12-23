using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalculate
{
   
    class KuaiSuSort
    {
        public void QuickSort(List<int> list,int left,int right)
        {
            if (left < right)
            {
                int i = Division(list, left, right);
                QuickSort(list,left,i-1);
                QuickSort(list,i+1,right);
            }
        }

        public int Division(List<int> list, int left, int right)
        {
            int baseNum = list[left];

            while (left<right)
            {
                while (left < right && list[right] >= baseNum)
                    right--;

                list[left] = list[right];

                while (left < right && list[left] <= baseNum)
                    left++;

                list[right] = list[left];

            }
            list[left] = baseNum;

           // Console.WriteLine(string.Join(",",list));
            return right;
        }


        public void Sort(List<int> list, int left, int right)
        {

            if (left < right)
            {
                var i = left;
                var j = right;
                var baseNum = list[left];

                while (i < j)
                {

                    while (i < j && list[j] >= baseNum)
                        j--;

                    list[i] = list[j];


                    while (i < j && list[i] <= baseNum)
                        i++;

                    list[j] = list[i];

                }
                list[i] = baseNum;
               //Console.WriteLine(string.Join(",", list));
                Sort(list,left,i);
                Sort(list,i+1,right);
            }

        }




    }






}
