
public class Osoba
{
    string imie, nazwisko;
    public Osoba()
    {
        Console.Write("Podaj imie: ");
        string imie = Console.ReadLine();
        Console.Write("Podaj nazwisko: ");
        string nazwisko = Console.ReadLine();
    }
    public void Edytuj()
    {
        bool warunek = true;
        while (warunek)
        {
            Console.WriteLine("Co chcesz edytowac?\n1 - Imie\n2 - Nazwisko");
            switch (Console.ReadLine())
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    warunek = false;
                    break;
            }
        }

    }
}
public class Uczestnik : Osoba
{
    string pseudonim;
    public Organizator()
    {

    }
}
public class Sedzia : Osoba
{
    public Sedzia()
    {
        
    }
}
public class Organizator : Osoba
{
    int numer_telefonu;
    public Organizator()
    {

    }
}

