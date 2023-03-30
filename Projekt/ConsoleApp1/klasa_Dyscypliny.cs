public class Dyscypliny
{
	string nazwa;
	string zasady;
	int czas_trwania;
	public Dyscypliny(string nazwa, string zasady, int czas_trwania)
	{
		this.nazwa = nazwa;
		this.zasady = zasady;
		this.czas_trwania = czas_trwania;
		Console.WriteLine("Dyscyplina zostala stworzona!");
	}
	public void EdytujDyscypline()
	{
		Console.Write("Co chcesz zmienic 1-nazwe 2-zasady 3-czas trwania (w min): ");
		int x = Convert.toInt32(Console.ReadLine());
		switch (x)
		{
			case 1:
				Console.Write("Podaj nowa nazwe: ");
				string y = Console.ReadLine();
				this.nazwa = y;
				break;
            case 2:
                Console.Write("Podaj nowe zasady: ");
                string y = Console.ReadLine();
                this.zasady = y;
                break;
            case 2:
                Console.Write("Podaj nowy czas trwania (w min): ");
                int y = Convert.ToInt32(Console.ReadLine());
                this.czas_trwania = y;
                break;
        }
	}
	public void WypiszDyscypline()
	{
		Console.WriteLine("Dyscyplina: {0}", this.nazwa);
        Console.WriteLine("Zasady: {0}", this.zasady);
        Console.WriteLine("Czas trwania w minutach: {0}", this.czas_trwania);
    }
}
