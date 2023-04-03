public static class Funkcje
{
    public static string PodajString(string content)
    {
        try
        {
            Console.Write($"Podaj {content}: ");
            string a = Console.ReadLine();
            if (a == null || a == "")
                throw new Exception($"{content} musi skladac sie z chociaz jednego znaku!");
            return a;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "";
        }
    }
    public static int PodajInt(string content)
    {
        try
        {
            Console.Write($"Podaj {content}: ");
            string a = Console.ReadLine();
            int number;
            if (a == null)
                throw new Exception($"{content} musi skladac sie z chociaz jednego znaku!");
            if (!int.TryParse(a, out number))
                throw new Exception($"{content} musi byc liczba calkowita!");
            return int.Parse(a);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }
}