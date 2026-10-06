using Begroeting;

namespace Begroeting.Tests;

public class BegroeterTests
{
    [Fact]
    public void Begroet_MetNaam_GeeftPersoonlijkeBegroeting()
    {
        Assert.Equal("Hallo, Sam!", Begroeter.Begroet("Sam"));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void Begroet_ZonderNaam_GeeftStandaardBegroeting(string? naam)
    {
        Assert.Equal("Hallo, onbekende!", Begroeter.Begroet(naam));
    }

    [Fact]
    public void Begroet_VerwijdertOverbodigeSpaties()
    {
        Assert.Equal("Hallo, Sam!", Begroeter.Begroet("  Sam  "));
    }
}
