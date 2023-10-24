// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");
//<------------------Klient------------------>
Klient klient = new Klient();
Console.Write("Podaj imię klienta: ");
klient.Imie = Console.ReadLine();
Console.Write("Podaj nazwisko klienta: ");
klient.Nazwisko = Console.ReadLine();
Console.Write("Podaj numer telefonu klienta: ");
klient.NumerTelefonu = Console.ReadLine();
Console.Write("Podaj adres klienta: ");
klient.Adres = Console.ReadLine();
Console.WriteLine();
klient.WyswietlDaneKlienta();
Console.ReadLine();
//<------------------Bank------------------>
Bank bank = new Bank();
Console.Write("Podaj nazwę banku: ");
bank.Nazwa = Console.ReadLine();
Console.Write("Podaj adres banku: ");
bank.Adres = Console.ReadLine();
bool kontynuuj = true;
while (kontynuuj)
{
   Klient2 klientnew = new Klient2();
   Console.Write("Podaj imię klienta: ");
   klientnew.Imie = Console.ReadLine();
   Console.Write("Podaj nazwisko klienta: ");
   klientnew.Nazwisko = Console.ReadLine();
   Console.Write("Podaj numer telefonu klienta: ");
   klientnew.NumerTelefonu = Console.ReadLine();
   Console.Write("Podaj adres klienta: ");
   klientnew.Adres = Console.ReadLine();
   bank.DodajKlienta(klientnew);
   Console.Write("Czy chcesz dodać kolejnego klienta? (T/N): ");
   kontynuuj = Console.ReadLine().Trim().ToUpper() == "T";
}
bank.WyswietlWszystkichKlientow();
Console.ReadLine();

//<------------------Samochód------------------>
Samochod samochod = new Samochod();
Console.Write("Podaj markę samochodu: ");
samochod.Marka = Console.ReadLine();
Console.Write("Podaj rok produkcji samochodu: ");
if (int.TryParse(Console.ReadLine(), out int rokProdukcji))
{
    samochod.RokProdukcji = rokProdukcji;
}
else
{
    Console.WriteLine("Błędny format roku produkcji.");
}
Console.Write("Podaj cenę samochodu: ");
if (decimal.TryParse(Console.ReadLine(), out decimal cena))
{
    samochod.Cena = cena;
}
else
{
    Console.WriteLine("Błędny format ceny.");
}
bool kontynuujj = true;
while (kontynuujj)
{
    Console.Write("Dodaj nowy model samochodu: ");
    string nowyModel = Console.ReadLine();
    samochod.DodajModel(nowyModel);

    Console.Write("Czy chcesz dodać kolejny model? (T/N): ");
    kontynuujj = Console.ReadLine().Trim().ToUpper() == "T";
}
Console.WriteLine();
samochod.WyswietlInformacje();
Console.ReadLine();
//<------------------Produkt------------------>
Produkt produkt = new Produkt();
Console.Write("Podaj nazwę produktu: ");
produkt.Nazwa = Console.ReadLine();
Console.Write("Podaj cenę produktu: ");
if (decimal.TryParse(Console.ReadLine(), out decimal cenaa))
{
    produkt.Cena = cenaa;
}
else
{
    Console.WriteLine("Błędny format ceny.");
}
bool kontynuuj2 = true;
while (kontynuuj)
{
    Console.Write("Podaj ilość produktu do dodania do magazynu: ");
    if (int.TryParse(Console.ReadLine(), out int ilosc))
    {
        produkt.DodajIlosc(ilosc);
    }
    else
    {
        Console.WriteLine("Błędny format ilości.");
    }

    Console.Write("Czy chcesz dodać kolejną ilość produktu? (T/N): ");
    kontynuuj2 = Console.ReadLine().Trim().ToUpper() == "T";
}
produkt.WyswietlInformacje();
Console.WriteLine($"Łączna cena za wszystkie produkty: {produkt.ObliczCene():C}");
Console.ReadLine();
//<------------------Student------------------>
Student student = new Student();
Console.Write("Podaj imię studenta: ");
student.Imie = Console.ReadLine();
Console.Write("Podaj nazwisko studenta: ");
student.Nazwisko = Console.ReadLine();
Console.Write("Podaj numer indeksu studenta: ");
student.NumerIndeksu = Console.ReadLine();
bool kontynuuj3 = true;
while (kontynuuj3)
{
    Console.Write("Podaj ocenę studenta (2-5): ");
    if (int.TryParse(Console.ReadLine(), out int ocena))
    {
        student.DodajOcene(ocena);
    }
    else
    {
        Console.WriteLine("Błędny format oceny.");
    }

    Console.Write("Czy chcesz dodać kolejną ocenę? (T/N): ");
    kontynuuj3 = Console.ReadLine().Trim().ToUpper() == "T";
}
kontynuuj3 = true;
while (kontynuuj3)
{
    Console.Write("Podaj datę obecności studenta (RRRR-MM-DD): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
    {
        Console.Write("Czy student był obecny? (T/N): ");
        bool obecny = Console.ReadLine().Trim().ToUpper() == "T";
        student.DodajObecnosc(data, obecny);
    }
    else
    {
        Console.WriteLine("Błędny format daty.");
    }

    Console.Write("Czy chcesz dodać kolejną obecność? (T/N): ");
    kontynuuj3 = Console.ReadLine().Trim().ToUpper() == "T";
}
Console.WriteLine();
student.WyswietlInformacje();
Console.WriteLine($"Procent obecności: {student.ObliczProcentObecnosci():0.00}%");
Console.WriteLine($"Średnia ocen: {student.ObliczSredniaOcen():0.00}");
Console.ReadLine();