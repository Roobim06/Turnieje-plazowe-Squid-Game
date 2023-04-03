using System;
public static class Program
{
    public static void Main()
    {
        Druzyny druzyny = new Druzyny();
        Dyscypliny dyscypliny = new Dyscypliny("aaaa","bbbb",123);
        dyscypliny.WypiszDyscypline();
        dyscypliny.EdytujDyscypline();
        dyscypliny.WypiszDyscypline();
        Console.WriteLine("aaaaaa");
    }
    public static void PodajString(string content)
    {
        Console.Write($"Podaj {content}: ");
        string nazwisko = Console.ReadLine();
    }
}