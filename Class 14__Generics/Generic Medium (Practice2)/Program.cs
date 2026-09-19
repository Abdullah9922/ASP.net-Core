
using Generic_Medium__Practice2_;

Calculator<int>.Add(22,4);
Calculator<double>.Add(28.245,4.146);
Calculator<int>.Multiply(22,4);


int[] arr = new int[] { 25, 14, 62, 1, 4, 5, 2, 3, 6, 9, 7, 4 };
ArrayHelper<int> help = new ArrayHelper<int>();
Console.WriteLine(help.GetFirst(arr));
Console.WriteLine(help.GetCount(arr, 4));

