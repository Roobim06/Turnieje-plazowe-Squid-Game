using System;
public static class Program
{
    public static void Main()
    {
        Druzyny druzyna = new Druzyny("aaa",1,2);
        Uczestnik uczestnik = new Uczestnik();
        druzyna.DodajZawodnikow(uczestnik);
    }
}