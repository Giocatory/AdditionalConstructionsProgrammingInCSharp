using LessonOne;

/*
 non-generic collections - System.Collections;
 generic collections - System.Collections.Generic;
 */

// System.Collections.ArrayList
// Can store anything
MyArrayList myArray = new();
myArray.AddArrayToArray("One", "Two", "Three");
myArray.AddArrayToArray(new string[] { "Four", "Five" });
myArray.AddValue("six");
myArray.ShowArray();
/*
1) One (System.String)
2) Two (System.String)
3) Three (System.String)
4) Four (System.String)
5) Five (System.String)
6) six (System.String)
*/
myArray.AddValue(7);
myArray.AddValue(7.2m);
myArray.ShowArray();
/*
...
7) 7 (System.Int32)
8) 7,2 (System.Decimal)
*/