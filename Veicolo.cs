namespace Esercizio1;

public class Veicolo
{
    public string Tipo { get; set; }
    public string Marca { get; set; }

    public Veicolo(string tipo, string marca)
    {
        Tipo = tipo;
        Marca = marca;
    }

    public void StampaInfo()
    {
        Console.WriteLine($"Veicolo: {Marca}, Tipo: {Tipo}");
    }
}
