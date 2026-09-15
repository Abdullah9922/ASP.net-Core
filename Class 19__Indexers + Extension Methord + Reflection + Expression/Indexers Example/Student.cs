using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers_Example
{
    public class Student
    {
        private string[] names = new string[3];

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
}
