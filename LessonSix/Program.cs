using LessonSix;

HelloMeaasage myLambda = name => $"{name}! We work with delegates and lambda expressions";
Console.WriteLine(myLambda.Invoke("Mikhail")); // Mikhail! We work with delegates and lambda expressions

EvenNumbers en = new();

en.AddRangeToList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 161, 71, 68);

en.TraditionalDelegateSyntax();
/*
Here is Even numbers:
2, 4, 6, 8, 10, 12, 14, 68,
*/

en.AnonymousMethodSyntax();
/*
Here is Odd numbers:
1, 3, 5, 7, 9, 11, 13, 15, 161, 71,
*/

public delegate string HelloMeaasage(string name);