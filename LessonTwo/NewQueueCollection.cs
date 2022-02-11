namespace LessonTwo
{
    internal class NewQueueCollection
    {
        private static void GetCoffe(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee");
        }

        public static void UseGenericQueue()
        {
            // Create a queue of three people.
            Queue<Person> peopleQ = new();
            peopleQ.Enqueue(new Person { FirstName = "Mike", LastName = "sbk", Age = 34 });
            peopleQ.Enqueue(new Person { FirstName = "Margo", LastName = "sbk", Age = 3 });
            peopleQ.Enqueue(new Person { LastName = "sbk", FirstName = "Tanya", Age = 33 });

            // Who is first in line?
            Console.WriteLine($"{peopleQ.Peek().FirstName} first in line");

            // Remove everyone from the queue
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());

            // Try to take someone out of the queue
            try
            {
                GetCoffe(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error: {e.Message}"); // queue is empty!
            }
        }
    }
}