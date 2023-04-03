using System;
public static class Program
{
    public static void Main()
    {
        Druzyny druzyna = new Druzyny("aaa",1,2);
    }
    public static void PodajString(string content)
    {
        Console.Write($"Podaj {content}: ");
        string nazwisko = Console.ReadLine();
    }
}