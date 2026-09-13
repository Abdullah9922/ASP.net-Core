using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Instance_making__Sorting_
{
    public class BubbleSort : Sort
    {
        public BubbleSort(int[] numbers) : base(numbers)
        {

        }

        public override void SortAscending()
        {
            Console.WriteLine("Sorting using Bubble sort algorithm");
        }
    }
}
