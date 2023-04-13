using System;

public class Druzyny
{
	List<Uczestnik> Zawodnicy = new List<Uczestnik> {  };
	string nazwa_druzyny;
	int ilosc_wygranych_gier;
	int ilosc_przegranych_gier;
	public Druzyny(string nazwa, int wyg, int prz)
	{
		this.nazwa_druzyny = nazwa;
		this.ilosc_wygranych_gier = wyg;
		this.ilosc_przegranych_gier=prz;
		Console.WriteLine("druzyna {0} zostala stworzona", nazwa_druzyny);
	}
	public void DodajZawodnikow(Uczestnik zawodnik)
	{
		Zawodnicy.Add(zawodnik);
		Console.WriteLine("zawodnik o imieniu zostal dodany");
	}
	public void Edytuj()
	{
        Console.WriteLine("Co chcesz edytowac?\n1 - Nazwe\n2 - Ilosc wygranych gier\n3 - Ilosc przegranych gier\nInne - zamknij");
		switch (Convert.ToInt32(Console.ReadLine()))
		{
			case 1:
				Console.WriteLine("podaj nowa nazwe: ");
				this.nazwa_druzyny = Console.ReadLine();
				break;
            case 2:
                Console.WriteLine("podaj nowa ilosc: ");
                this.ilosc_wygranych_gier = Convert.ToInt32(Console.Read());
				break;
            case 3:
                Console.WriteLine("podaj nowa ilosc: ");
                this.ilosc_przegranych_gier = Convert.ToInt32(Console.Read());
				break;
			default:
				break;
        }
    }
}
