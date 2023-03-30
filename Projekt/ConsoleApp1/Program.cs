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
    void PodajString(string content)
    {
        Console.Write($"Podaj {a}: ");
        string nazwisko = Console.ReadLine();
    }
}