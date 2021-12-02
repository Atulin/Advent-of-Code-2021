var lines = await File.ReadAllLinesAsync("./input.txt");
var numbers = lines.Select(int.Parse).ToArray();

var count = 0;
for (var i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > numbers[i - 1]) count++;
}

Console.WriteLine($"There are {count} values higher than previous values");