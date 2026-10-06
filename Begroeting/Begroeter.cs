namespace Begroeting;

/// <summary>
/// Bevat de logica om een begroeting samen te stellen.
/// We zetten dit in een aparte klasse zodat we het kunnen testen,
/// los van Console.ReadLine/WriteLine.
/// </summary>
public static class Begroeter
{
    public static string Begroet(string? naam)
    {
        if (string.IsNullOrWhiteSpace(naam))
        {
            return "Hallo, onbekende!";
        }

        return $"Hallo, {naam.Trim()}!";
    }
}
