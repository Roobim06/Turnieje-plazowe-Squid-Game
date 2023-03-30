using System;
public static class Program
{
    public static void Main()
    {
        Dyscypliny dyscypliny = new Dyscypliny("aaaa","bbbb",123);
        dyscypliny.WypiszDyscypline();
        dyscypliny.EdytujDyscypline();
        dyscypliny.WypiszDyscypline();

    }
    public static void PodajString(string content)
    {
        Console.Write($"Podaj {content}: ");
        string nazwisko = Console.ReadLine();
    }
}