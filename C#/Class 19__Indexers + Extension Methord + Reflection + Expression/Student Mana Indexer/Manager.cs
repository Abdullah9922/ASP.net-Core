using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Mana_Indexer
{
    public class Manager
    {
        private Student[] manager;

        public Manager(Student[] students)
        {
            this.manager = students;
        }

        public Student this[int index]
        {
            get
            {
                return manager[index];
            }

            set
            {
                manager[index] = value;
            }
        }
    }
}
