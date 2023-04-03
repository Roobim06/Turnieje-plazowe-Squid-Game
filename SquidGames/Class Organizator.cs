using static Funkcje;
public class Organizator : Osoba
{
    protected int numer_telefonu;
    public Organizator()
    {
        imie = PodajString("imie");
        nazwisko = PodajString("nazwisko");
        numer_telefonu = PodajInt("numer telefonu");
    }
    public void Edytuj()
    {
        bool warunek = true;
        while (warunek)
        {
            Console.WriteLine("Co chcesz edytowac?\n1 - Imie\n2 - Nazwisko\n3 - nr_telefonu\nInne - zamknij");
            switch (Console.ReadLine())
            {
                case "1":
                    imie = PodajString("imie");
                    break;
                case "2":
                    nazwisko = PodajString("nazwisko");
                    break;
                case "3":
                    numer_telefonu = PodajInt("numer telefonu");
                    break;
                default:
                    warunek = false;
                    break;
            }
        }
    }
}