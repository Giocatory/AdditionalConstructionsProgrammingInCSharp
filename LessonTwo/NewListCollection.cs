namespace LessonTwo
{
    internal class NewListCollection
    {
        public static void UseGenerList()
        {
            List<Person> people = new()
            {
                new Person() { FirstName = "Mikhail", LastName = "SBK", Age = 34 },
                new Person() { FirstName = "Tanya", LastName = "SBK", Age = 33 },
            };
            people.Add(new Person() { FirstName = "Margo", LastName = "SBK", Age = 3 });

            Console.WriteLine($"Created {people.Count} peoples...\n");
            Console.WriteLine(String.Join("\n", people));
            Console.WriteLine("\n");
        }
    }
}