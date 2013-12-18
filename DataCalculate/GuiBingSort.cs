using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    class GuiBingSort
    {

        public void MergeSort(List<int> array, int[] temparray, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right)/2;
                MergeSort(array,temparray,left,middle);
                MergeSort(array,temparray,middle+1,right);
               
                Merge(array, temparray, left, middle + 1, right);
            }

        }

        public void Merge(List<int> array, int[] temparray, int left, int middle, int right)
        {
            int leftEnd = middle - 1;
            int rightStart = middle;

            int tempIndex = left;
            int tempLength = right - left + 1;

            while ((left <= leftEnd) && (rightStart<=right))
            {
                if (array[left] < array[rightStart])
                    temparray[tempIndex++] = array[left++];
                else
                    temparray[tempIndex++] = array[rightStart++];
            }

            while (left<=leftEnd)
            {
                temparray[tempIndex++] = array[left++];
            }

            while (rightStart<=right)
            {
                temparray[tempIndex++] = array[rightStart++];
            }

            for (int i = 0; i < tempLength; i++)
            {
                array[right] = temparray[right];
                right--;
            }


        }



        public void Sort(List<int> list)
        {
            
        }
    }

}
