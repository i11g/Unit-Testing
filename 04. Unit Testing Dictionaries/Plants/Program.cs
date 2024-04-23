using System.Numerics;
using System.Text;

static string GetFastestGrowing(string[] plants)
    {
    Dictionary<int, List<string>> groupedPlants = new();

    foreach (string plant in plants)
    {
        int length = plant.Length;
        groupedPlants.TryAdd(length, new());
        groupedPlants[length].Add(plant);
    }

    StringBuilder sb = new();
    foreach (KeyValuePair<int, List<string>> kvp in groupedPlants.OrderBy(kv => kv.Key))
    {
        sb.AppendLine($"Plants with {kvp.Key} letters:");
        foreach (string plant in kvp.Value)
        {
            sb.AppendLine(plant);
        }
    }

    return sb.ToString().Trim();
}
string[] input = { "tulips", "orchidea", "mango" };
string result = GetFastestGrowing(input);
Console.WriteLine(result);