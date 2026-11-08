using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public bool IsActive { get; set; }
        public List<Topic> TopicList { get; set; } 
    }
}
