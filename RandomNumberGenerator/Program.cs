using System.Diagnostics;

Console.WriteLine("Type min number");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type max number");
int maxNumber = Convert.ToInt32(Console.ReadLine());
// Set a variable to the Documents path.
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
List<int> list = new();
bool @break = false;
while (!@break)
{
    int number = new Random().Next(minNumber, maxNumber + 1);
    if (list.Contains(number))
    {
        using StreamWriter streamWriter = new(Path.Combine(docPath, "MagicNumber.txt"));
        await streamWriter.WriteLineAsync($"Magic number: {number}");
        @break = true;
    }
    else
    {
        list.Add(number);
    }
}
new Process
{
    StartInfo = new(Path.Combine(docPath, "MagicNumber.txt"))
    {
        UseShellExecute = true,
    }
}.Start();