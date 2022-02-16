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

QueryOverStrings();
/*
Fallout 3
System Shok 2
*/

static void QueryOverStrings()
{
    string[] currentVideoGames = { "Diablo", "Fallout 3", "Morrowwind", "System Shok 2" };
    // LINQ query
    // var == IEnumerable<string>
    var subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;
    foreach (var video in subset) { Console.WriteLine(video); }
}