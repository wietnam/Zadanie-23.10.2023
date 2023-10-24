using System;

class Klient
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

