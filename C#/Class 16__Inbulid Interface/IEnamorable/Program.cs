//void Print(IEnumerable<int> numbers)
//{
//    foreach (int x in numbers)
//        Console.WriteLine(x);
//}

//List<int> list = new List<int> { 1, 2, 3 };

//int[] arr = { 4, 5, 6 };

//HashSet<int> set = new HashSet<int> { 7, 8, 9 };

//Print(list); // ✅
//Print(arr);  // ✅
//Print(set);  // ✅




using IEnamorable;

BinarySearchTree<int> tree = new BinarySearchTree<int>();

tree.Add(10);
tree.Add(5);
tree.Add(20);
tree.Add(2);
tree.Add(7);
tree.Add(15);
tree.Add(30);

foreach (int value in tree)
{
    Console.WriteLine(value);
}