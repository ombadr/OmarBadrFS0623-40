namespace Esercizio1;

public class Dipendente
{
    public string Nome { get; set; }
    public string Posizione { get; set; }

    public Dipendente(string nome, string posizione)
    {
        Nome = nome;
        Posizione = posizione;
    }

    public void StampaInfo()
    {
        Console.WriteLine($"Dipendente: {Nome}, Posizione: {Posizione}");
    }
}
