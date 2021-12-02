var lines = await File.ReadAllLinesAsync("./input.txt");
var numbers = lines.Select(int.Parse).ToArray();

var count = 0;
for (var i = 3; i < numbers.Length; i++)
{
    var a = numbers[(i - 3)..i];
    var b = numbers[(i - 2)..(i + 1)];

    Console.WriteLine($"a: {string.Join(',', a)}, b: {string.Join(',', b)}");
    
    if (b.Sum() > a.Sum()) count++;
}

Console.WriteLine($"There are {count} values higher than previous values");