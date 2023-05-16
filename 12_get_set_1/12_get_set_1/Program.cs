Darbinieks darbinieks = new Darbinieks();
Console.Write("Ievadiet darbinieka vārdu: ");
darbinieks.vards = Console.ReadLine();
Console.Write("Ievadiet darbinieka uzvārdu: ");
darbinieks.uzvards = Console.ReadLine();
Console.Write("Ievadiet darbinieka dzimsanas gadu: ");
darbinieks.dzimsanasGads = int.Parse(Console.ReadLine());
Console.WriteLine($"Vards: {darbinieks.vards}");
Console.WriteLine($"Uzvards: {darbinieks.uzvards}");
Console.WriteLine($"Vecums: {darbinieks.vecums}");
class Darbinieks
{
    private string Vards;
    public string vards
    {
        get
        {
            return Vards;
        }
        set
        {
            if (value.Length > 20)
            {
                Vards = "Nedefinets";
            }
            else
            {
                Vards = value;
            }
        }
    }
    private string Uzvards;
    public string uzvards
    {
        get
        {
            if (Vards == "Nedefinets")
            {
                return "Vards nav definēts";
            }
            else
            {
                return Uzvards;
            }
        }
        set
        {
            Uzvards = value;
        }
    }
    private int DzimsanasGads;
    public int dzimsanasGads
    {
        set
        {
            DzimsanasGads = value;
        }
    }
    public int Vecums;
    public int vecums
    {
        get
        {
            return Vecums = 2023 - DzimsanasGads;
        }
    }
}