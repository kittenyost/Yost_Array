// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();

List<int> listRandoms = new List<int>();

while (listRandoms.Count < 50)
{
    int random = new Random().Next(65, 122);

    if ((random > 90 && random < 97) || listRandoms.Contains(random))
    {
        continue;
    }

    listRandoms.Add(random);
}

string randomOutput = string.Join(",", listRandoms.Select(r => Convert.ToChar(r).ToString()));

sw.Stop();

Console.WriteLine(randomOutput);
Console.WriteLine($"Operation took {sw.ElapsedMilliseconds.ToString()} milliseconds to complete");