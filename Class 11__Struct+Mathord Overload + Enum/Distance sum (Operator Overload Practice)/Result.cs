using System;
using System.Collections.Generic;
using System.Text;

namespace Distance_sum__Operator_Overload_Practice_
{
    public class Result
    {
        public int Bangla { get; set; }
        public int English { get; set; }
        public int Math { get; set; }


        public Result(int bangla, int english , int math)
        {
            Bangla = bangla;
            English = english;
            Math = math;
        }

        public static Result operator + (Result a, Result b)
        {
            return new Result(a.Bangla + b.Bangla, a.English + b.English, a.Math + b.Math);
        }

        public static bool operator >(Result a, Result b)
        {
            int totalA = a.Bangla + a.English + a.Math;
            int totalB = b.Bangla + b.English + b.Math;

            return totalA > totalB;
        }

        public static bool operator <(Result a, Result b)
        {
            int totalA = a.Bangla + a.English + a.Math;
            int totalB = b.Bangla + b.English + b.Math;

            return totalA > totalB;
        }

        public static bool operator ==(Result a, Result b)
        {
            int totalA = a.Bangla + a.English + a.Math;
            int totalB = b.Bangla + b.English + b.Math;

            return totalA == totalB;
        }

        public static bool operator !=(Result a, Result b)
        {
            int totalA = a.Bangla + a.English + a.Math;
            int totalB = b.Bangla + b.English + b.Math;

            return totalA != totalB;
        }
    }
}
