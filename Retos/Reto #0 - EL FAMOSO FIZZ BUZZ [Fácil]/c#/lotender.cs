var numeroB = new List<int>();
var numero3 = new List<int>();
var numero5 = new List<int>();

for (int i = 1; i <= 100; i++)
{
    numeroB.Add(i);
}
foreach (var item in numeroB)
{
    var total = item * 3;
    if (total <= 100)
    {
        numero3.Add(total);
    }
}
foreach (var item in numeroB)
{
    var total = item * 5;
    if (total <= 100)
    {
        numero5.Add(total);
    }
}


foreach (var numeroBase in numeroB)
{
    var fizz = numero3.Contains(numeroBase);
    var Buzz = numero5.Contains(numeroBase);
    if (fizz && Buzz)
    {
        Console.WriteLine($"FIZZ BUZZ {numeroBase}");
    }
    else if (fizz)
    {
        Console.WriteLine($"FIZZ {numeroBase}");
    }
    else if (Buzz)
    {
        Console.WriteLine($"BUZZ {numeroBase}");
    }
    else
    {
        Console.WriteLine(numeroBase);
    }

}
