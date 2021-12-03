var lines = await File.ReadAllLinesAsync("./input.txt");
var lineLength = lines[0].Length;


// Calculate values for oxygen
var oxygenList = lines.ToList();
for (var i = 0; i < lineLength; i++)
{
    if (oxygenList.Count == 1) break;
    var values = CountAtLocation(oxygenList, i);
    _ = oxygenList.RemoveAll(x => values.Zeroes > values.Ones ? x[i] == '1' : x[i] == '0');
}

var oxygenValue = Convert.ToInt32(oxygenList[0], 2);
Console.WriteLine($"Oxygen value is {oxygenList[0]} or {oxygenValue}");


// Calculate values for carbon dioxide
var carbonDioxideList = lines.ToList();
for (var i = 0; i < lineLength; i++)
{
    if (carbonDioxideList.Count == 1) break;
    var values = CountAtLocation(carbonDioxideList, i);
    _ = carbonDioxideList.RemoveAll(x => values.Zeroes <= values.Ones ? x[i] == '1' : x[i] == '0');
}

var carbonDioxideValue = Convert.ToInt32(carbonDioxideList[0], 2);
Console.WriteLine($"Oxygen value is {carbonDioxideList[0]} or {carbonDioxideValue}");

// Result
Console.WriteLine($"Thus, the result is {oxygenValue * carbonDioxideValue}");


/*****************************************\
|*        Methods and classes            *|
\*****************************************/

Values CountAtLocation(IEnumerable<string> haystack, int index)
{
    var values = new Values();
    foreach (var str in haystack)
    {
        if (str[index] == '0') values.Zeroes++;
        if (str[index] == '1') values.Ones++;
    }
    return values;
}

internal class Values
{
    public int Zeroes { get; set; }
    public int Ones { get; set; }
}