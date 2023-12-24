// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new List<int> { 1, 2, 3 };
var b = new List<int> { 3, 2, 1 };

var result = CompareTriplets(a, b);

foreach (var item in result)
{
    Console.WriteLine(item);
}

static List<int> CompareTriplets(List<int> a, List<int> b)
{
    var c = new List<int>();
    if (a == null || !a.Any() || b == null || !b.Any() || a.Count != b.Count)
    {
        return c;
    }
    int ac = 0;
    int bc = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > b[i])
        {
            ac = ac + 1;
        }
        else if (b[i] > a[i])
        {
            bc = bc + 1;
        }
    }
    c.Add(ac);
    c.Add(bc);
    return c;
}

Console.ReadLine();