using System.Diagnostics.Metrics;
using System.Text;

static string Order(params string[] input)
{
    Dictionary<string, decimal[]> products = new();

    foreach (string s in input)
    {
        string[] data = s.Split();

        string product = data[0];
        decimal price = decimal.Parse(data[1]);
        decimal quantity = decimal.Parse(data[2]);

        products.TryAdd(product, new[] { (decimal)0.0, (decimal)0.0 });
        products[product][1] += quantity;
        products[product][0] = price;
    }

    StringBuilder sb = new();
    foreach (KeyValuePair<string, decimal[]> pair in products)
    {
        decimal totalPrice = pair.Value[1] * pair.Value[0];
        sb.AppendLine($"{pair.Key} -> {totalPrice:f2}");
    }

    return sb.ToString().Trim();
}
string[] input = 
{ "Beer 2.20 100",

"IceTea 1.50 50",

"NukaCola 3.30 80",

"Water 1.00 500"
};
string result = Order(input);
Console.WriteLine(result);