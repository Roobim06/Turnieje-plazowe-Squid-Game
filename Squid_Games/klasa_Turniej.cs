using static Funkcje;
class Turniej
{
    List<Organizator> organizatorzy = new List<Organizator>(); // List<Organizatorzy>
    List<string> gra = new List<string>(); //List<Gra>
    string miejsce, data;
    public Turniej()
    {
        miejsce = PodajString("miejsce");
        data = PodajString("data");
    }
    public void Edytuj()
    {
        bool warunek = true;
        while (warunek)
        {
            Console.WriteLine("Co chcesz edytowac?\n1 - Miejsce\n2 - Datę\n3 - Organizatorów\n4 - grę \nInne - zamknij");
            switch (Console.ReadLine())
            {
                case "1":
                    miejsce = PodajString("miejsce");
            break;
                case "2":
                    data = PodajString("data");
            break;
                case "3"
                    break;
                case "4":
                    break;

            default:

                    warunek = false;

            break;

        }

    }

}

}



