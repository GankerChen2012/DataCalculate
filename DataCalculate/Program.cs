using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalculate
{

    //排序分为四种： 
    //  交换排序： 包括冒泡排序，快速排序。
    //  选择排序： 包括直接选择排序，堆排序。
    //  插入排序： 包括直接插入排序，希尔排序。
    //  合并排序： 合并排序。

    //http://www.cnblogs.com/huangxincheng/archive/2011/11/14/2249046.html

    //冒泡的时间复杂度为： 0(n) - 0(n^2)
    //快排的时间复杂度为:  平均复杂度： N(logN)  最坏复杂度：  0(n^2)
     //直接选择排序的时间复杂度为：O(n^2)
     //堆排序的时间复杂度：O(NlogN)
     //插入排序的时间复杂度为：O(N^2)
     //希尔排序的时间复杂度为：平均为：O(N^3/2)  最坏： O(N^2)
     //归并排序时间复杂度为： O(NlogN)  空间复杂度为:  O(N) 

    //经测试发现： 归并1 > 希尔1 > 堆1 > 快排1 > 直插1 > 直选1 > 冒泡1

    internal class Program
    {
        private static void Main(string[] args)
        {

            //Sort();

            //kmp算法
            //KmpCalculate kc=new KmpCalculate();

            //四则运算
            //Calculate calculate = new Calculate();
            //string str = "9 + 5 * ( 2 + 4 * ( 3 + 2 ) / 5 ) - 1";
            //calculate.CalculateSum(str);

            Tree tree=new Tree();

            Console.ReadLine();
        }

        public static void Sort()
        {
            //冒泡排序
            var maoPao = new MaoPaoSort();
            //快速排序
            var kuaiPai = new KuaiSuSort();
            //直接选择排序
            var zx = new ZhiXuanSort();
            //堆排序
            var ds=new DuiSort();
            //直接插入排序
            var zc=new ZhiChaSort();
            //希尔排序
            var xr=new XiErSort();

            //归并排序
            var gb = new GuiBingSort();  

            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                var list = new List<int>();
                for (var j = 0; j < 100000; j++)
                {
                    var s = rd.Next(0, 100);
                    list.Add(s);
                }
                Stopwatch sw = new Stopwatch();
               
                var list21 = new List<int>(list);
                var list22 = new List<int>(list);
                var list31 = new List<int>(list); 
                var list32 = new List<int>(list);
                var list4 = new List<int>(list);
                var list51 = new List<int>(list);
                var list52 = new List<int>(list);
                var list61 = new List<int>(list);
                var list62 = new List<int>(list);
                var list71 = new List<int>(list);
                var list72 = new List<int>(list);

                sw = new Stopwatch();
                sw.Start();
                kuaiPai.QuickSort(list, 0, list.Count - 1);
                sw.Stop();
                Console.WriteLine("------快排1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);

                //sw = new Stopwatch();
                //sw.Start();
                //maoPao.Sort1(list21);
                //sw.Stop();
                //Console.WriteLine("------冒泡1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                //sw = new Stopwatch();
                //sw.Start();
                //maoPao.Sort2(list22);
                //sw.Stop();
                //Console.WriteLine("------冒泡2-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);


                //sw = new Stopwatch();
                //sw.Start();
                //zx.Sort1(list31);
                //sw.Stop();
                //Console.WriteLine("------直选1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                //sw = new Stopwatch();
                //sw.Start();
                //zx.Sort2(list32,0);
                //sw.Stop();
                //Console.WriteLine("------直选2-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);


                //sw = new Stopwatch();
                //sw.Start();
                //ds.Sort(list4);
                //sw.Stop();
                //Console.WriteLine("------堆排1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);


                //sw = new Stopwatch();
                //sw.Start();
                //zc.Sort1(list51);
                //sw.Stop();
                //Console.WriteLine("------直插1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                //sw = new Stopwatch();
                //sw.Start();
                //zc.Sort2(list52);
                //sw.Stop();
                //Console.WriteLine("------直插2-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);

               
                //sw = new Stopwatch();
                //sw.Start();
                //xr.Sort(list61);
                //sw.Stop();
                //Console.WriteLine("------希尔1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                //sw = new Stopwatch();
                //sw.Start();
                //xr.Sos(list62);
                //sw.Stop();
                //Console.WriteLine("------希尔2-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);


                sw = new Stopwatch();
                sw.Start();
                gb.MergeSort(list71, new int[list71.Count], 0, list71.Count - 1);
                sw.Stop();
                Console.WriteLine("------归并1-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                //sw = new Stopwatch();
                //sw.Start();
                //gb.Sort(list72);
                //sw.Stop();
                //Console.WriteLine("------归并2-----------第{0}次------------时间：{1}---------------", i + 1, sw.Elapsed);
                

                //Console.WriteLine(string.Join(",",list));


                Console.WriteLine(" ");
            }

        }


        public static void Aasswwe(List<int> list,int left,int right)
        {
            
        }



    }
}
