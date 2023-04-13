using static Funkcje;
public class Uczestnik : Osoba
{
    protected string pseudonim;
    public Uczestnik()
    {
        pseudonim = PodajString("pseudonim");
    }
    public void Edytuj()
    {
        bool warunek = true;
        while (warunek)
        {
            Console.WriteLine("Co chcesz edytowac?\n1 - Imie\n2 - Nazwisko\n3 - Pseudonim\nInne - zamknij");
            switch (Console.ReadLine())
            {
                case "1":
                    imie = PodajString("imie");
                    break;
                case "2":
                    nazwisko = PodajString("nazwisko");
                    break;
                case "3":
                    pseudonim = PodajString("pseudonim");
                    break;
                default:
                    warunek = false;
                    break;
            }
        }
    }
}