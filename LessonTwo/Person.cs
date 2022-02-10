namespace LessonTwo
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() : this("no-name", "no-name", 0)
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Age}";
        }
    }
}