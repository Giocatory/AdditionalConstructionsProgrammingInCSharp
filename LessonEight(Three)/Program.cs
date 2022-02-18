// Returning LINQ Results

IEnumerable<string> subset = GetStringSubset();
foreach (var sub in subset) { Console.WriteLine(sub); }
/*
Light Red
Dark Red
Red
*/

List<string> subset2 = GetStringsListSubset();
foreach (var sub2 in subset2) { Console.WriteLine(sub2); }
/*
Dark Yellow
Dark Red
*/

static IEnumerable<string> GetStringSubset()
{
    string[] colors = { "Light Red", "Green", "Dark Yellow", "Dark Red", "Red", "Purple" };

    return (from c in colors where c.Contains("Red") select c);
}

static List<string> GetStringsListSubset()
{
    string[] colors = { "Light Red", "Green", "Dark Yellow", "Dark Red", "Red", "Purple" };

    return (from c in colors where c.Contains("Dark") select c).ToList<string>();
}