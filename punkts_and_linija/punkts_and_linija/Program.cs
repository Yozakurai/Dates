using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ievadiet Līnīju skaitu: ");
        int n = int.Parse(Console.ReadLine());

        Linija[] linijas = new Linija[n]; //Līnijas masīvs ar lietotāja ievadīto masīva izmēru

        for (int i = 0; i < n; i++)
        {
            linijas[i] = new Linija();
            Console.WriteLine($"Ievadiet datus priekš {i + 1}. līnijas");
            linijas[i].Reģistrēt();
        }

        Console.WriteLine("Līniju dati:");
        foreach(Linija l in linijas)
        {
            l.Izvadīt();
        }
    }
}
public class Punkts
{
    public int X;
    public int Y;
    public string Krasa;

    public void Reģistrēt()
    {
        Console.Write("Ievadiet punkta X vērtību: ");
        X = int.Parse(Console.ReadLine());
        Console.Write("Ievadiet punkta Y vērtību: ");
        Y = int.Parse(Console.ReadLine());
        Console.Write("Ievadiet krāsu: ");
        Krasa = Console.ReadLine();
    }
    public void Izvadīt()
    {
        Console.WriteLine($"Punkta X vērtība ir {X}");
        Console.Write($"Punkta Y vērtība ir {Y}");
    }
}

public class Linija
{
    public Punkts A;
    public Punkts B;
    public string Krasa;

    public void Reģistrēt()
    {
        Console.WriteLine("Reģistrējam punktu A...");
        A = new Punkts();
        A.Reģistrēt();
        Console.WriteLine("Reģistrējam punktu B...");
        B = new Punkts();
        B.Reģistrēt();
        Console.Write("Ievadiet līnijas krāsu: ");
        Krasa = Console.ReadLine();

    }
    public double Garums()
    {
        return Math.Round(Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)), 2);
    }

    public void Izvadīt()
    {
        Console.WriteLine($"Līnija A: ({A.X},{A.Y}), Krāsa: {A.Krasa}");
        Console.WriteLine($"Līnija B: ({B.X},{B.Y}), Krāsa: {B.Krasa}");
        Console.WriteLine($"Krāsa: {Krasa}");
        Console.WriteLine($"Garums: {Garums()}");
    }
}
