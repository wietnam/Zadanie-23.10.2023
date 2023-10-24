using System;

class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int IloscWMagazynie { get; set; }

    public Produkt()
    {
        IloscWMagazynie = 0;
    }

    public void DodajIlosc(int ilosc)
    {
        IloscWMagazynie += ilosc;
    }

    public void UsunIlosc(int ilosc)
    {
        if (ilosc <= IloscWMagazynie)
        {
            IloscWMagazynie -= ilosc;
        }
        else
        {
            Console.WriteLine("Brak wystarczającej ilości produktów do usunięcia.");
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Informacje o Produkcie:");
        Console.WriteLine($"Nazwa: {Nazwa}");
        Console.WriteLine($"Cena: {Cena:C}");
        Console.WriteLine($"Ilość w magazynie: {IloscWMagazynie}");
    }

    public decimal ObliczCene()
    {
        return Cena * IloscWMagazynie;
    }
}