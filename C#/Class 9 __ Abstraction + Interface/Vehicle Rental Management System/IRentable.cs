using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public interface IRentable
    {
        double CalculateRent(int days);
    }
}
