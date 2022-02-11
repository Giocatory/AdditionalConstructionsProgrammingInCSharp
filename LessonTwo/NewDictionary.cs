namespace LessonTwo
{
    internal class NewDictionary
    {
        public static void UseDictionary()
        {
            Dictionary<string, Person> people = new();
            people.Add("Father", new Person { FirstName = "Mike", LastName = "Der", Age = 34 });
            people.Add("Mother", new Person { FirstName = "Tanya", LastName = "Der", Age = 33 });
            people.Add("First child", new Person { FirstName = "Margo", LastName = "Der", Age = 31 });

            Console.WriteLine();

            foreach (var element in people)
            {
                Console.WriteLine($"{element.Key}: \"{element.Value}\"");
            }
            Console.WriteLine("\n");
        }
    }
}