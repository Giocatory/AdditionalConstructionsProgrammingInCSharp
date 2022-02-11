/*
The SortedSet<T> class is useful in that when elements are inserted or removed, it automatically
mathically ensures that the elements in a set are sorted (auto sort when insert)
*/

namespace LessonTwo
{
    internal class NewSortedSet : IComparer<Person>
    {
        public int Compare(Person? firstPerson, Person? secondPerson)
        {
            if (firstPerson?.Age > secondPerson?.Age) return 1;
            if (firstPerson?.Age < secondPerson?.Age) return -1;
            return 0;
        }

        public static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new(new NewSortedSet())
            {
                new Person { FirstName = "Mike", LastName = "sbk", Age = 34 },
                new Person { FirstName = "Tanya", LastName = "sbk", Age = 33 },
                new Person { FirstName = "Margo", LastName = "sbk", Age = 3 },
                new Person { FirstName = "Varvara", LastName = "sbk", Age = 1 },
            };
            Console.WriteLine();
            Console.WriteLine(String.Join("\n", setOfPeople));

            setOfPeople.Add(new Person { FirstName = "Gera", LastName = "sbk", Age = 2 });
            Console.WriteLine();
            Console.WriteLine(String.Join("\n", setOfPeople));
        }
    }
}