using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    internal class MaoPaoSort
    {
        public void Sort1(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = list.Count - 1; j > i; j--)
                {
                    if (list[j - 1] <= list[j])
                        continue;

                    var temp = list[j - 1];
                    list[j - 1] = list[j];
                    list[j] = temp;
                }
            }

        }

        public void Sort2(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (var j = 0; j < list.Count - i - 1; j++)
                {
                    var num1 = list[j];
                    var num2 = list[j + 1];
                    if (num1 <= num2) continue;

                    var temp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = temp;
                }
            }
        }
        

    }
}
