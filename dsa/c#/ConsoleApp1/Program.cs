Console.WriteLine("Hello, World!");

var counts = new Dictionary<string, int>();

string[] categories = { "api", "db", "api", "security" };

foreach (var category in categories)
{
    if (counts.ContainsKey(category))
        counts[category]++;
    else
        counts[category] = 1;
}
