using LessonOne;
/*
 non-generic collections - System.Collections;
 generic collections - System.Collections.Generic;
 */

// ArrayList
MyArrayList myArray = new();
myArray.AddArrayToArray("One", "Two", "Three");
myArray.AddArrayToArray(new string[] { "Four", "Five" });
myArray.AddValue("Six");
myArray.ShowArray();
/*
1) One
2) Two
3) Three
4) Four
5) Five
6) Six
*/