var lines = await File.ReadAllLinesAsync("./input.txt");

var counts = new Values[lines[0].Length].Select(_ => new Values()).ToArray();

foreach (var l in lines)
{
    for (var i = 0; i < l.Length; i++)
    {
        var ch = l[i];
        switch (ch)
        {
            case '0':
                counts[i].Zeroes++;
                break;
            case '1':
                counts[i].Ones++;
                break;
        }
    }
}

Console.WriteLine("Counts are as follows:");
Console.WriteLine(string.Join("\n", counts.Select(c => c.ToString())));

var gamma = string.Join("", counts.Select(c => c.Ones > c.Zeroes ? '1' : '0'));
var epsilon = string.Join("", counts.Select(c => c.Ones > c.Zeroes ? '0' : '1'));

Console.WriteLine($"The gamma is {gamma} and epsilon is {epsilon}");

var result = Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);

Console.WriteLine($"And the result is {result}");

class Values
{
    public int Zeroes { get; set; }
    public int Ones { get; set; }

    public override string ToString() => $"(Zeroes: {Zeroes}, Ones: {Ones})";
}