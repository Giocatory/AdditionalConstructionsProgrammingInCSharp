namespace LessonSix
{
    internal class EvenNumbers
    {
        private List<int> numbers = new();
        public List<int> Numbers { get => numbers; set => numbers = value; }

        public void AddRangeToList(params int[] nums) => numbers.AddRange(nums);

        public void TraditionalDelegateSyntax()
        {
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = numbers.FindAll(callback);
            Console.WriteLine("Here is Even numbers:");
            foreach (int evenNumber in evenNumbers) Console.Write($"{evenNumber}, ");
            Console.WriteLine();
        }
        private bool IsEvenNumber(int i)
        {
            return (i % 2 == 0);
        }
        public void AnonymousMethodSyntax()
        {
            // anonymous delegate call
            // List<int> OddNumbers = numbers.FindAll(delegate (int numbers) { return numbers % 2 != 0; });
            // with lambda
            List<int> OddNumbers = numbers.FindAll(num => num % 2 != 0);
            Console.WriteLine("Here is Odd numbers:");
            foreach (int odd in OddNumbers) Console.Write($"{odd}, ");
            Console.WriteLine();
        }
    }
}
