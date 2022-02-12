namespace LessonThree
{
    internal class MyGenericClass
    {
        public static void Swap<anyType>(ref anyType a, ref anyType b) // any type can be used
        {
            Console.WriteLine($"Поменять местами два элемента, типа {typeof(anyType)}");
            anyType temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine($"Base class of {typeof(T)}: \"{typeof(T).BaseType}\"");
        }
    }
}