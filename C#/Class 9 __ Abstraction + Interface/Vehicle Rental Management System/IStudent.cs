using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public interface IStudent
    {
        // 1. Only get
        string Name { get; }

        // 2. Only set
        int Age { set; }

        // 3. Both get and set
        string Department { get; set; }
    }
}
