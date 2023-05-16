Veikals obj1 = new Veikals();
obj1.Registret();
obj1.Izvadit();
class Prece
{
    public string Nosaukums;
    public double Iepirksanas_cena;
    public void Izvaditt()
    {
        Console.WriteLine($"\nNosaukums: {Nosaukums}");
        Console.WriteLine($"Iepirksanas cena: {Iepirksanas_cena}");
    }
}
class Partikas_Prece : Prece
{
    public DateTime Deriguma_termins;
    public bool Ir_alregisks;
    public string Mervieniba;
    public double Pardosanas_cena;
    public void Registret()
    {
        Console.WriteLine("\nIevadiet partikas preces nosaukumu:");
        Nosaukums = Console.ReadLine();
        Console.WriteLine($"Ievadiet preces {Nosaukums} iepirksanas cenu:");
        Iepirksanas_cena = Double.Parse(Console.ReadLine());
        Console.Write("Ievadiet deriguma terminu dd/MM/yyyy: ");
        Deriguma_termins = DateTime.Parse(Console.ReadLine());
        Console.Write("Ir alergisks? True/False: ");
        Ir_alregisks = bool.Parse(Console.ReadLine());
        Console.Write("Mervieniba: ");
        Mervieniba = Console.ReadLine();
        Pardosanas_cena = Iepirksanas_cena + Iepirksanas_cena * 0.3;
    }
    public void Izvadit()
    {
        Izvaditt();
        Console.WriteLine($"Deriguma termins: {Deriguma_termins}");
        Console.WriteLine($"Ir alergisks: {Ir_alregisks}");
        Console.WriteLine($"Mervieniba: {Mervieniba}");
        Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
    }
}
class Saimniecibas_Prece : Prece
{
    public string Materials;
    public bool Ir_bisatama;
    public double Pardosanas_cena;
    public void Registret()
    {
        Console.WriteLine("\nIevadiet saimniecības preces nosaukumu:");
        Nosaukums = Console.ReadLine();
        Console.WriteLine($"Ievadiet preces {Nosaukums} iepirksanas cenu:");
        Iepirksanas_cena = Double.Parse(Console.ReadLine());
        Console.Write("Materials: ");
        Materials = Console.ReadLine();
        Console.Write("Ir bistams? True/False: ");
        Ir_bisatama = bool.Parse(Console.ReadLine());
        Pardosanas_cena = Iepirksanas_cena + Iepirksanas_cena * 0.5;
    }
    public void Izvadit()
    {
        Izvaditt();
        Console.WriteLine($"Materials: {Materials}");
        Console.WriteLine($"Ir bistams: {Ir_bisatama}");
        Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
    }
}
class Veikals
{
    public string Nosaukums;
    public int Partikas_precu_ckaits;
    public int Saimniecibas_precu_skaits;
    Partikas_Prece[] Partikas_preces;
    Saimniecibas_Prece[] Saimniecibas_preces;
    public void Registret()
    {
        Console.WriteLine("Ievadiet veikala nosaukumu:");
        Nosaukums = Console.ReadLine();
        Console.WriteLine("Ievadiet partikas precu skaitu:");
        Partikas_precu_ckaits = int.Parse(Console.ReadLine());
        Console.WriteLine("Ievadiet saimniecibas precu skaitu:");
        Saimniecibas_precu_skaits = int.Parse(Console.ReadLine());
        Partikas_preces = new Partikas_Prece[Partikas_precu_ckaits];
        for (int i = 0; i < Partikas_preces.Length; i++)
        {
            Partikas_preces[i] = new Partikas_Prece();
            Partikas_preces[i].Registret();
        }
        Saimniecibas_preces = new Saimniecibas_Prece[Saimniecibas_precu_skaits];
        for (int j = 0; j < Saimniecibas_preces.Length; j++)
        {
            Saimniecibas_preces[j] = new Saimniecibas_Prece();
            Saimniecibas_preces[j].Registret();
        }
    }
    public void Izvadit()
    {
        Console.WriteLine("\n=========================================================================");
        Console.WriteLine($"\nVeikala nosaukums: {Nosaukums}");
        Console.WriteLine($"Partikas precu skaits: {Partikas_precu_ckaits}");
        Console.WriteLine($"Saimniecibas precu skaits: {Saimniecibas_precu_skaits}");
        Console.WriteLine($"\nPartikas preces:");
        for (int i = 0; i < Partikas_preces.Length; i++)
        {
            Partikas_preces[i].Izvadit();
        }
        Console.WriteLine("\nSaimniecibas preces:");
        for (int j = 0; j < Saimniecibas_preces.Length; j++)
        {
            Saimniecibas_preces[j].Izvadit();
        }
        Veikala_tips();
        Atlasit_arpus_termina();
        Atlasit_bistamus();
    }
    public void Veikala_tips()
    {
        if (Partikas_precu_ckaits == 0)
        {
            Console.WriteLine("Veikala tips: Saimniecibas veikals");
        }
        else if (Saimniecibas_precu_skaits == 0)
        {
            Console.WriteLine("Veikala tips: Partikas viekals");
        }
        else
        {
            Console.WriteLine("Veikala tips: Lielveikals");
        }
    }
    public void Atlasit_arpus_termina()
    {
        Console.WriteLine("\nDeriguma termins beidzas:");
        DateTime currentDate = DateTime.Today;
        for (int i = 0; i < Partikas_preces.Length; i++)
        {
            if (Partikas_preces[i].Deriguma_termins <= currentDate)
            {
                Console.WriteLine(Partikas_preces[i].Nosaukums);
            }
            else
            {

            }
        }
    }
    public void Atlasit_bistamus()
    {
        Console.WriteLine("\nBistamas preces:");
        for (int i = 0; i < Saimniecibas_preces.Length; i++)
        {
            if (Saimniecibas_preces[i].Ir_bisatama == true)
            {
                Console.WriteLine(Saimniecibas_preces[i].Nosaukums);
            }
            else
            {

            }
        }
    }
}