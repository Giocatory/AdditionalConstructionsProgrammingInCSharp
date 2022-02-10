using LessonTwo;

UseGenerList();
/*
Created 3 peoples...

Mikhail SBK: 34
Tanya SBK: 33
Margo SBK: 3
*/

UseGenericStack();
/*
First person is: Lisa Simpson: 9
Popped off Lisa Simpson: 9

First person is: Marge Simpson: 45
Popped off Marge Simpson: 45

First person item is: Homer Simpson: 47
Popped off Homer Simpson: 47

Error! Stack empty.
*/

static void UseGenerList()
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

static void UseGenericStack()
{
    Stack<Person> stackOfPeople = new();
    stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

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