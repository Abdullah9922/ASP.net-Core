using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method_Example
{
    public static class StudentExtensions
    {
        public static bool IsAdult(this Student student) // data type ar age this
        {
            return student.Age >= 18;
        }
    }
}
