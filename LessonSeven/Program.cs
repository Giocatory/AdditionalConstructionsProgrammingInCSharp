using LessonSeven;

// перегрузка операторов
// operator overloading
Point pointOne = new(3, 10);
Point pointTwo = new(-1, 15);
Point pointThree = pointOne + pointTwo;

Console.WriteLine(pointThree); // [2; 25]

pointThree -= pointOne;
Console.WriteLine(pointThree); // [-1; 15]

Console.WriteLine(++pointOne); // [4; 11]
Console.WriteLine(--pointTwo); // [-2; 14]