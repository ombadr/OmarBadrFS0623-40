using Esercizio1;

class Program
{
    static void Main(string[] args)
    {
        Atleta atleta = new Atleta("Mario", "Calcio");
        Dipendente dipendente = new Dipendente("Giuseppe", "Programmatore");
        Animale animale = new Animale("Cane", "Mario");
        Veicolo veicolo = new Veicolo("Moto", "Yamaha");

        atleta.StampaInfo();
        dipendente.StampaInfo();
        animale.StampaInfo();
        veicolo.StampaInfo();

    }
}