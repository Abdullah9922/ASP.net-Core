using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Processing__Practice_
{
    public class StudentManager<T>
    {
        private List<T> students = new List<T>();
        
        public void Add(T student)
        {
            students.Add(student);
        }

        public void Process(Func<T,bool>condition, Action<T> print)
        {
            foreach(var x in students)
            {
                if (condition(x))
                {
                    print(x);
                }
            }
        }
    }
}
