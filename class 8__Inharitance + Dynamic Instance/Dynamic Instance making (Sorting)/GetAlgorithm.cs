using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Instance_making__Sorting_
{
    public class GetAlgorithm
    {
        public Sort GetSortingAlgorithm(string name, int[] numbers)
        {
            if (name == "heapsort") return new HeapSort(numbers);
            else if(name == "Qsort") return new QSort(numbers);
            else return new BubbleSort (numbers);
        }
    }
}
