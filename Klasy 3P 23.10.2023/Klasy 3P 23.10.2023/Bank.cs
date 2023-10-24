using System;
using System.Collections.Generic;

class Klient2
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string NumerTelefonu { get; set; }
    public string Adres { get; set; }

    public void WyswietlDaneKlienta()
    {
        Console.WriteLine("Dane Klienta:");
        Console.WriteLine($"Imię: {Imie}");
        Console.WriteLine($"Nazwisko: {Nazwisko}");
        Console.WriteLine($"Numer Telefonu: {NumerTelefonu}");
        Console.WriteLine($"Adres: {Adres}");
    }
}

class Bank
{
    public string Nazwa { get; set; }
    public string Adres { get; set; }
    public List<Klient2> ListaKlientow { get; set; }

    public Bank()
    {
        ListaKlientow = new List<Klient2>();
    }

    public void DodajKlienta(Klient2 klient)
    {
        ListaKlientow.Add(klient);
    }

    public void UsunKlienta(Klient2 klient)
    {
        ListaKlientow.Remove(klient);
    }

    public void WyswietlWszystkichKlientow()
    {
        Console.WriteLine($"Bank: {Nazwa}");
        Console.WriteLine($"Adres: {Adres}");
        Console.WriteLine("Lista Klientów:");

        foreach (var klient in ListaKlientow)
        {
            klient.WyswietlDaneKlienta();
            Console.WriteLine();
        }
    }

    internal void DodajKlienta1(Klient2 nowyKlient)
    {
        throw new NotImplementedException();
    }
}

