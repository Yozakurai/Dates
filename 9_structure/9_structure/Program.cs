Console.Write("Ierakstiet darbinieku skaitu: ");
int darbinieku_skaits = int.Parse(Console.ReadLine());
Darbinieks[] darbinieks;
darbinieks = new Darbinieks[darbinieku_skaits];
for (int i = 0; i < darbinieku_skaits; i++) //reģistrē darbiniekus
{
    darbinieks[i] = new Darbinieks();
    darbinieks[i].Registret();
}

///izvēlne
do
{
    Console.WriteLine();
    Console.WriteLine("\nLūdzu izvēlaties metodi... \n1 - Ievadit darbinieku\n\n2 - Izvadit uz ekrana\n\n3 - Izvadit konkretu darbinieku\n");
    int izvele;
    Console.Write("Jūsu izvēle: ");
    izvele = int.Parse(Console.ReadLine());

    if (izvele == 1)
    {

        Array.Resize(ref darbinieks, darbinieks.Length + 1); //palielina masīvu
        for (int i = darbinieku_skaits; i < darbinieku_skaits + 1; i++) //ievada datus
        {
            darbinieks[i] = new Darbinieks();
            darbinieks[i].Registret();
        }
        darbinieku_skaits++; 
    }
    else if (izvele == 2)
    {
        Console.WriteLine();
        Console.WriteLine("ID\tVards\tUzvards\t\tBernu skaits\tAmats\t\tSlodze\n");
        foreach (Darbinieks n in darbinieks) //izvada datus
        {
            n.Izvadit();
        }
    }
    else if (izvele == 3)
    {
        Console.Write("\nIevadiet darbinieka ID: ");
        int id_meklet = int.Parse(Console.ReadLine());
        Console.WriteLine();
        IzvaditPecId(id_meklet, darbinieks);
    }
} while (true);

void IzvaditPecId(int id_meklet, Darbinieks[] darbinieks)
{
    Console.WriteLine("ID\tVards\tUzvards\t\tBernu skaits\tAmats\t\tSlodze\n");
    foreach (Darbinieks n in darbinieks)
    {
        if (n.id == id_meklet)
        {
            n.Izvadit();
        }
    }
}
public struct Darbinieks
{
    public int id;
    public string vards;
    public string uzvards;
    public int bernu_sk;
    public string amats;
    public bool slodze;
    public void Registret()
    {
        Console.Write("\nId: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("\nVārds: ");
        vards = Console.ReadLine();
        Console.Write("\nUzārds: ");
        uzvards = Console.ReadLine();
        Console.Write("\nBērnu skaits: ");
        bernu_sk = int.Parse(Console.ReadLine());
        Console.Write("\nAmats: ");
        amats = Console.ReadLine();
        Console.Write("\nSlodze: ");
        slodze = bool.Parse(Console.ReadLine());
        Console.Write("\n......");
        Console.Write("\n\n");
    }
    public void Izvadit()
    {

        Console.WriteLine($"{id}\t{vards}\t{uzvards}\t\t{bernu_sk}\t\t{amats}\t\t{slodze}\n");
    }
}
