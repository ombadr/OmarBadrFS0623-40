namespace Esercizio1;

public class Animale
{
    public string Specie { get; set; }
    public string Nome { get; set; }

    public Animale(string specie, string nome)
    {
        Specie = specie;
        Nome = nome;
    }

    public void StampaInfo()
    {
        Console.WriteLine($"Animale: {Nome}, Specie: {Specie}");
    }
}
