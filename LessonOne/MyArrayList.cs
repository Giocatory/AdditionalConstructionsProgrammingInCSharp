using System.Collections;

namespace LessonOne
{
    internal class MyArrayList
    {
        private ArrayList strArray = new();

        public void AddArrayToArray(params string[] values)
        {
            strArray.AddRange(values);
        }
        public void AddValue(string value)
        {
            strArray.Add(value);
        }
        public void ShowArray()
        {
            for (int i = 0; i < strArray.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {strArray[i]}");
            }
        }
    }
}
