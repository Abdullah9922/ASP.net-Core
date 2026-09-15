using Distance_sum__Operator_Overload_Practice_;

Distance d1 = new Distance(5, 8);
Distance d2 = new Distance(3, 7);

Distance result = d1 + d2;

result.Display();


Money<int> m1 = new Money<int>(500);
Money<int> m2 = new Money<int>(300);

Console.WriteLine(m1 > m2);

Result r1 = new Result(70, 80, 90);
Result r2 = new Result(70, 80, 90);

Console.WriteLine(r1 == r2);