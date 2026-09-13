using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Instance_making__Sorting_
{
    public class QSort : Sort
    {
        public QSort(int[] numbers) : base(numbers) { }

        public override void SortAscending()
        {
            Console.WriteLine("Sorting using qsort algorithm");
        }
    }
}
