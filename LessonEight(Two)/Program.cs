ImmediateExecution();
/*
Array
Length: 12; Type: System.Int32[]
List
Length: 5; Type: System.Collections.Generic.List[System.Int32]
*/

static void ImmediateExecution()
{
    int[] numbers = { 10, 11, 33, 22, 71, 39, 35, 34, 24, 36, 76, 65, 56, 44, 23, 5, 62 };

    int[] subsetArray = (from i in numbers where i < 50 select i).ToArray();

    List<int> subsetList = (from i in numbers where i > 50 select i).ToList<int>();

    Console.WriteLine("Array");
    Console.WriteLine($"Length: {subsetArray.Length}; Type: {subsetArray.GetType()}");

    Console.WriteLine("List");
    Console.WriteLine($"Length: {subsetList.Count}; Type: {subsetList.GetType()}");
}