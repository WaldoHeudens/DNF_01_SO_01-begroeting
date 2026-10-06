using Begroeting;

Console.Write("Wat is je naam? ");
string? naam = Console.ReadLine();

// De eigenlijke logica zit in een aparte, testbare method.
Console.WriteLine(Begroeter.Begroet(naam));
