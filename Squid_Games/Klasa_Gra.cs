using System;
//aaaaaa
public class Gra
{
    protected Druzyna druzyna1;
    protected Druzyna druzyna2;
    protected List<Sedzia> sedziowe = new List<Sedzia> { };
    protected Dyscypliny dyscyplina;
    protected string wynik;
    public Gra(Druzyna dr1, Druzyna dr2, Dyscypliny dys)
    {
        this.druzyna1 = dr1;
        this.druzyna2 = dr2;
        this.dyscyplina = dys;
    }
    public void DodajSedziego(Sedzia sedzia)
    {
        sedziowie.Add(sedzia);
        Console.WriteLine("szedia zostal dodany");
    }
    public void UstalWynik()
    {
        Console.WriteLine("podaj numer druzyny ktora wygrala: ");
        int x = Convert.ToInt32(Console.ReadLine());
        this.wynik = "Wygrala druzyna " + x;
    }
}
