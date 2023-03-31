using Xunit;
using EducazioneCivica;

public class EducazioneCivicaTests
{
    [Fact]
    public void Esercizio1Test()
    {
        var es1 = new Esercizio1();
        string result = EducazioneCivica.Esercizio1("ciao", 10);

        Assert.Equals(result, "msky");
    }
}