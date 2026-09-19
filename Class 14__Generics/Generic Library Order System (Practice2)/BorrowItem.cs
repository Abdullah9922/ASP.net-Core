using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Library_Order_System__Practice2_
{
    public class BorrowItem<TBook, TId> where TBook : IBorrowable<TId>
    {
        public TBook? Book { get; set; }
        public int Days { get; set; }

        public void FineCalculate()
        {
            if (Days <= 7) Console.WriteLine("No Fine for you.");
            else Console.WriteLine("Your Fine is : " + (Days - 7) * 20 + " Taka");
        }
    }
}
