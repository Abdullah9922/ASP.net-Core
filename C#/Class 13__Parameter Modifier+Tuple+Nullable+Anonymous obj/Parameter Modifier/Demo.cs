using System;
using System.Collections.Generic;
using System.Text;

namespace Parameter_Modifier
{
    public class Demo
    {
        public int Average(params int[] numbers)
        {
            var sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            }
            return sum / numbers.Length;
        }
    
        public void Test1(ref int a)
        {
            a = 5;
        }

        public void Test2(in int a)
        {
            int x = a;
        }

        public void Test3(out int a)
        {
            a = 7;
        }
    }
}
