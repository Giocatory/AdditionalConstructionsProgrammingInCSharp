namespace LessonTwo
{
    internal class NewStackCollection
    {
        public static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new();
            stackOfPeople.Push(new Person { FirstName = "Mike", LastName = "cbk", Age = 34 });
            stackOfPeople.Push(new Person { FirstName = "Tanya", LastName = "cbk", Age = 33 });
            stackOfPeople.Push(new Person { FirstName = "Margo", LastName = "cbk", Age = 3 });

            // View the top element, push it out and view it again.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}\n", ex.Message); // Ошибка! Стек пуст.
            }
        }
    }
}
