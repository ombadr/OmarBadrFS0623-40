namespace Esercizio1;

public class Atleta
{
    public string Nome { get; set; }
    public string Sport { get; set; }

    public Atleta(string nome, string sport)
    {
        Nome = nome;
        Sport = sport;
    }

    public void StampaInfo()
    {
        Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}");
    }
}
