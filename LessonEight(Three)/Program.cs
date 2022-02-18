// Returning LINQ Results

IEnumerable<string> subset = GetStringSubset();
foreach (var sub in subset) { Console.WriteLine(sub); }
/*
Light Red
Dark Red
Red
*/

static IEnumerable<string> GetStringSubset()
{
    string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

    return (from c in colors where c.Contains("Red") select c);
}