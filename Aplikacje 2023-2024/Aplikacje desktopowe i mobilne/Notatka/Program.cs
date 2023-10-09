class program
{
    static void Main(string[] args)
    {
        Notatka notatka1 = new Notatka("Notatka 1", "Treść notatki 1");
        Notatka notatka2 = new Notatka("Notatka 2", "Treść notatki 2");

        notatka1.Wyswietlanie_tytulu_tresci();
        notatka2.Wyswietlanie_tytulu_tresci();

        notatka1.metoda_diagnostyczna();
        notatka2.metoda_diagnostyczna();

        Console.ReadKey();
    }
}

public class Notatka
{
    private static uint SumaNotatek = 0;
    private uint identyfikator;
    private string tytul;
    private string tresc;

    public Notatka(string tytul, string tresc)
    {
        SumaNotatek++;
        identyfikator = SumaNotatek;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void Wyswietlanie_tytulu_tresci()
    {
        Console.WriteLine($"tytul: {tytul}");
        Console.WriteLine($"tresc: {tresc}");
    }

    public void metoda_diagnostyczna()
    {
        Console.WriteLine($"Identyfikator: {identyfikator}; Tytuł: {tytul}; tresc: {tresc}");
    }
}