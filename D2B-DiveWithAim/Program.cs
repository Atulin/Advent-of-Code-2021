var lines = await File.ReadAllLinesAsync("./input.txt");

var distance = 0;
var aim = 0;
var depth = 0;

foreach (var line in lines)
{
    var split = line.Split(' ');
    var value = int.Parse(split[1]);
    switch (split[0])
    {
        case "up":
            aim -= value;
            break;
        case "down":
            aim += value;
            break;
        case "forward":
            distance += value;
            depth += value * aim;
            break;
    }
}

Console.WriteLine($"Depth of {depth} and distance of {distance} gives us {depth * distance}");