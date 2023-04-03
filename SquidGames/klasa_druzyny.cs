using System;

public class Druzyny
{
	List<Uczestnik> Zawodnicy;
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
}
