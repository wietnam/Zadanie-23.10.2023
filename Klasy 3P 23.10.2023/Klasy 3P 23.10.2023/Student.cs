using System;

class Student
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string NumerIndeksu { get; set; }
    public List<int> ListaOcen { get; set; }
    public List<(DateTime Data, bool Obecny)> ListaObecnosci { get; set; }

    public Student()
    {
        ListaOcen = new List<int>();
        ListaObecnosci = new List<(DateTime, bool)>();
    }

    public void DodajOcene(int ocena)
    {
        if (ocena >= 2 && ocena <= 5)
        {
            ListaOcen.Add(ocena);
        }
        else
        {
            Console.WriteLine("Niewłaściwa ocena. Akceptowane są oceny od 2 do 5.");
        }
    }

    public void UsunOcene(int ocena)
    {
        if (ListaOcen.Contains(ocena))
        {
            ListaOcen.Remove(ocena);
        }
        else
        {
            Console.WriteLine("Nie znaleziono podanej oceny.");
        }
    }

    public void DodajObecnosc(DateTime data, bool obecny)
    {
        ListaObecnosci.Add((data, obecny));
    }

    public void UsunObecnosc(DateTime data)
    {
        var obecnosc = ListaObecnosci.FindIndex(p => p.Data.Date == data.Date);
        if (obecnosc != -1)
        {
            ListaObecnosci.RemoveAt(obecnosc);
        }
        else
        {
            Console.WriteLine("Nie znaleziono obecności na podaną datę.");
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Informacje o Studencie:");
        Console.WriteLine($"Imię: {Imie}");
        Console.WriteLine($"Nazwisko: {Nazwisko}");
        Console.WriteLine($"Numer Indeksu: {NumerIndeksu}");
        Console.WriteLine("Oceny:");

        foreach (var ocena in ListaOcen)
        {
            Console.Write($"{ocena} ");
        }
        Console.WriteLine();

        Console.WriteLine("Obecności:");

        foreach (var obecnosc in ListaObecnosci)
        {
            Console.WriteLine($"{obecnosc.Data.ToShortDateString()}: {(obecnosc.Obecny ? "Obecny" : "Nieobecny")}");
        }
    }

    public double ObliczProcentObecnosci()
    {
        if (ListaObecnosci.Count == 0)
        {
            return 100.0; 
        }

        int obecne = 0;
        foreach (var obecnosc in ListaObecnosci)
        {
            if (obecnosc.Obecny)
            {
                obecne++;
            }
        }

        return (double)obecne / ListaObecnosci.Count * 100;
    }

    public double ObliczSredniaOcen()
    {
        if (ListaOcen.Count == 0)
        {
            return 0.0; 
        }

        int sumaOcen = 0;
        foreach (var ocena in ListaOcen)
        {
            sumaOcen += ocena;
        }

        return (double)sumaOcen / ListaOcen.Count;
    }
}
