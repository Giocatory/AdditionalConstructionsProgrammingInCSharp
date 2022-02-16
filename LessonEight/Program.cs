// LINQ
/*
•  LINQ to Objects.
Этот термин относится к действию по применению запросов LINQ к массивам и коллекциям.
•  LINQ to XML.
Этот термин относится к действию по использованию LINQ для ма­нипулирования и запрашивания документов XML.
•  LINQ to DataSet.
Этот термин относится к действию по применению запросов LINQ к объектам DataSet из ADO.NET.
•  LINQ to Entities.
Этот аспект LINQ позволяет использовать запросы LINQ внутри API-интерфейса ADO.NET Entity Framework (EF).
•  Parallel LINQ(он же PLINQ).
Этот аспект делает возможной параллельную обработ­ку данных, возвращаемых из запроса LINQ.
*/

// var query = from g in SomeCollection where g.Contains(" ") orderby g select g;
Console.WriteLine("Games with \" \"");
QueryOverStrings();
/*
Games with " "
***** Info about your query using Query Expression *****
resultSet is of type: OrderedEnumerable`2       <-
resultSet location: System.Linq
Fallout 3
System Shok 2
*/

// var query = SomeCollection.Where(lambda).OrderBy(lambda).Select(lambda);
Console.WriteLine("Games start with \"D\" or \"M\"");
QueryOverStnngsWithExtensionMethods();
/*
Games start with "D" or "M"
***** Info about your query using Query Expression *****
resultSet is of type: SelectIPartitionIterator`2        <-
resultSet location: System.Linq
Diablo
Morrowwind
*/

static void QueryOverStrings()
{
    string[] currentVideoGames = { "Diablo", "Fallout 3", "Morrowwind", "System Shok 2" };
    // LINQ query
    // var == IEnumerable<string>
    var subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;

    ReflectOverQueryResult(subset);

    subset.ToArray();
    foreach (var video in subset) { Console.WriteLine(video); }
}

static void QueryOverStnngsWithExtensionMethods()
{
    string[] currentVideoGames = { "Diablo", "Fallout 3", "Morrowwind", "System Shok 2" };
    // or query expression
    var subsetTwo = currentVideoGames.Where(g => g.StartsWith("D") || g.StartsWith("M")).OrderBy(g => g).Select(g => g);

    ReflectOverQueryResult(subsetTwo);

    subsetTwo.ToList<string>();
    foreach (var video in subsetTwo) { Console.WriteLine(video); }
}

static void ReflectOverQueryResult(object resultSet, string queryType = "Query Expression")
{
    Console.WriteLine($"***** Info about your query using {queryType} *****");
    Console.WriteLine($"resultSet is of type: {resultSet.GetType().Name}");
    Console.WriteLine($"resultSet location: {resultSet.GetType().Assembly.GetName().Name}");
}