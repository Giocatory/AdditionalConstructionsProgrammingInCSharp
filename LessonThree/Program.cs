using LessonThree;

// Creating Special Generic Methods
int a = 1, b = 2;
MyGenericClass.Swap<int>(ref a, ref b);
Console.WriteLine($"a - {a}; b - {b}\n\n");
/*
Поменять местами два элемента, типа System.Int32
a - 2; b - 1
*/

string sa = "World", sb = "Hello";
// MyGenericClass.Swap<string>(ref sa, ref sb);
MyGenericClass.Swap(ref sa, ref sb);
Console.WriteLine($"a - {sa}; b - {sb}\n\n");
/*
Поменять местами два элемента, типа System.String
a - Hello; b - World
*/

MyGenericClass.DisplayBaseClass<string>(); // Base class of System.String: "System.Object"
MyGenericClass.DisplayBaseClass<int>(); // Base class of System.Int32: "System.ValueType"