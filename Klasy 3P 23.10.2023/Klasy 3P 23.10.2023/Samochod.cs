using System;

class SamochodModel
{
    public string Model { get; set; }
}

class Samochod
{
    public string Marka { get; set; }
    public List<SamochodModel> Modele { get; set; }
    public int RokProdukcji { get; set; }
    public decimal Cena { get; set; }

    public Samochod()
    {
        Modele = new List<SamochodModel>();
    }

    public void DodajModel(string model)
    {
        SamochodModel nowyModel = new SamochodModel { Model = model };
        Modele.Add(nowyModel);
    }

    public void UsunModel(string model)
    {
        SamochodModel modelDoUsuniecia = Modele.Find(m => m.Model == model);
        if (modelDoUsuniecia != null)
        {
            Modele.Remove(modelDoUsuniecia);
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Informacje o Samochodzie:");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine("Modele:");

        foreach (var model in Modele)
        {
            Console.WriteLine($"- {model.Model}");
        }

        Console.WriteLine($"Rok Produkcji: {RokProdukcji}");
        Console.WriteLine($"Cena: {Cena:C}");
    }
}

        