using System.Collections;

// Filtering data using the OfType<T> method

ArrayList myStuff = new();
myStuff.AddRange(new object[] { 10, 40, false, "any string", true });

int[] myInts = myStuff.OfType<int>().ToArray();
foreach (var i in myInts) { Console.WriteLine(i); }
// 10
// 40