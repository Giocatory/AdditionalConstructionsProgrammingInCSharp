using LessonFour;

// Creating Special Generic Classes and Structures

// Точка с координатами типа int.
Point<int> p = new(10, 10);

Console.WriteLine($"p.ToString() = {p}"); // p.ToString() = (10; 10)
p.ResetPoint();
Console.WriteLine($"p.ToString() = {p}"); // p.ToString() = (0; 0)
Console.WriteLine();

// Точка с координатами типа double.
Point<double> p2 = new(5.4, 3.3);

Console.WriteLine($"p2.ToString() = {p2}"); // p2.ToString() = (5,4; 3,3)
p2.ResetPoint();
Console.WriteLine($"p2.ToString() = {p2}"); // p2.ToString() = (0; 0)
Console.ReadLine();