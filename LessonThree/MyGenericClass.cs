namespace LessonThree
{
    internal class MyGenericClass
    {
        public static void Swap<T>(ref T a, ref T b) // any type can be used
        {
            Console.WriteLine($"Поменять местами два элемента, типа {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine($"Base class of {typeof(T)}: \"{typeof(T).BaseType}\"");
        }
    }
}