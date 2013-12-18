using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    internal abstract class Operator
    {
        public string Type;
        public Operator Next;
        public abstract double DisPlay(string type, double num1, double num2);
    }

    internal class Add : Operator
    {
        public Add()
        {
            Type = "+";
        }
        public override double DisPlay(string type, double num1, double num2)
        {
            if (Type == type)
            {
                return num1 + num2;
            }
            return Next.DisPlay(type, num1, num2);
        }
    }
    internal class Sub : Operator
    {
        public Sub()
        {
            Type = "-";
        }
        public override double DisPlay(string type, double num1, double num2)
        {
            if (Type == type)
            {
                return num1 - num2;
            }
            return Next.DisPlay(type, num1, num2);
        }
    }
    internal class Mul : Operator
    {
        public Mul()
        {
            Type = "*";
        }
        public override double DisPlay(string type, double num1, double num2)
        {
            if (Type == type)
            {
                return num1 * num2;
            }
            return Next.DisPlay(type, num1, num2);
        }
    }
    internal class Div : Operator
    {
        public Div()
        {
            Type = "/";
        }
        public override double DisPlay(string type, double num1, double num2)
        {
            if (Type == type)
            {
                return num1 / num2;
            }
            return Next.DisPlay(type, num1, num2);
        }
    }
    internal class Error : Operator
    {
        public override double DisPlay(string type, double num1, double num2)
        {
            Console.WriteLine("符号错误:"+type);
            return -9999;
        }
    }
    class Calculate
    {
        private readonly Add add;
        public Calculate()
        {
            add=new Add();
            Sub sub=new Sub();
            Mul mul=new Mul();
            Div div=new Div();
            Error error=new Error();
            add.Next = sub;
            sub.Next = mul;
            mul.Next = div;
            div.Next = error;

        }

        public void CalculateSum(string value)
        {
            var chs = value.Split(' ');
            var opers = new List<string>();
            var nums = new List<double>();

            for (int index = 0; index < chs.Length; index++)
            {
                var str = chs[index];

                double num;
                if (double.TryParse(str, out num))
                {
                    nums.Add(num);
                    continue;
                }

                if (opers.Count == 0 || str == "(" || opers[opers.Count - 1]=="(")
                {
                    opers.Add(str);
                }
                else switch (str)
                {
                    case "-":
                    case "+":
                        CalculateValue(nums, opers);
                        opers.Add(str);
                        break;
                    case ")":
                        while (true)
                        {
                            var oper = opers[opers.Count - 1];
                            if (oper == "(")
                            {
                                opers.RemoveAt(opers.Count - 1);
                                break;
                            }
                            CalculateValue(nums, opers);
                        }
                        break;
                    default:
                        opers.Add(str);
                        break;
                }
            }
            while (nums.Count != 1)
            {
                CalculateValue(nums, opers);
            }
        }

        private void CalculateValue(List<double> nums, List<string> opers)
        {
            var opear = opers[opers.Count - 1];
            var num1 = nums[nums.Count - 1];
            var num2 = nums[nums.Count - 2];
            var sum = add.DisPlay(opear, num2, num1);
            Console.WriteLine("{0}{1}{2}={3}", num2, opear, num1, sum);
            nums.RemoveAt(nums.Count - 1);
            nums.RemoveAt(nums.Count - 1);
            opers.RemoveAt(opers.Count - 1);
            nums.Add(sum);
        }

        




    }
}
