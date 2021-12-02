var lines = await File.ReadAllLinesAsync("./input.txt");

var distance = 0;
var depth = 0;

foreach (var line in lines)
{
    var split = line.Split(' ');
    var value = int.Parse(split[1]);
    switch (split[0])
    {
        case "up":
            depth -= value;
            break;
        case "down":
            depth += value;
            break;
        case "forward":
            distance += value;
            break;
    }
}

Console.WriteLine($"Depth of {depth} and distance of {distance} gives us {depth * distance}");