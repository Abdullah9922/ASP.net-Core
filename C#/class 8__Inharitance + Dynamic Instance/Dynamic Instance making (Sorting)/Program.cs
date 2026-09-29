using Dynamic_Instance_making__Sorting_;
Console.WriteLine("Hello, World!");

string algorithmName = Console.ReadLine();

Sort sorting = new GetAlgorithm().GetSortingAlgorithm(algorithmName, [3, 4, 2, 5,]);
sorting.SortAscending();