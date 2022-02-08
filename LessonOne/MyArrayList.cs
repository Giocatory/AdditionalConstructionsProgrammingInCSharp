using System.Collections;

namespace LessonOne
{
    internal class MyArrayList
    {
        private readonly ArrayList strArray = new();

        public void AddArrayToArray(params object[] values)
        {
            strArray.AddRange(values);
        }

        public void AddValue(object value)
        {
            strArray.Add(value);
        }

        public void ShowArray()
        {
            for (int i = 0; i < strArray.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {strArray[i]} ({strArray[i].GetType()})");
            }
            Console.WriteLine();
        }
    }
}