using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona();
        p.Reģistrēt();
        p.Izvadīt();
        p.PietiekLīdzekļu();
    }
}
public class Prece
{

    public string nosaukums;
    public double cena;

    public void Reģistrēt()  //ievadam klases mainīgos
    {
        Console.Write("Ievadiet preces nosaukumu: ");
        nosaukums = Console.ReadLine();
        Console.Write("Ievadiet preces cenu: ");
        cena = Convert.ToDouble(Console.ReadLine());
    }

    public void Izvadīt() //izvadam datus
    {
        Console.WriteLine("Preces nosaukums: " + nosaukums);
        Console.WriteLine("\tPreces cena: " + cena + " Eur");
    }

}

public class Grozs
{
    public int skaits;
    public Prece[] Preces; //Klases Prece masivs
    public void Reģistrēt() //izsaucam funkcijas no klasēm lai reģistrētu preces
    {
        Console.Write("Ievadiet preču skaitu grozā:");
        skaits = int.Parse(Console.ReadLine());
        Preces = new Prece[skaits];
        for (int i = 0; i < skaits; i++)
        {
            Prece prece = new Prece();
            prece.Reģistrēt();
            Preces[i] = prece;
        } 

    }
    public double Kopsumma() //saskaitam katru preci ar sevi lai dabutu kopējo summu
    {
        double sum = 0;
        foreach (Prece prece in Preces)
        {
            sum += prece.cena;
        }
        return sum;
    }
    public void Izvadīt() //izvadam groza datus
    {
        int count = 1;
        Console.WriteLine("\tPreču skaits grozā: " + skaits);
        Console.WriteLine("\tGroza preces:");

        foreach (Prece prece in Preces)
        {
            Console.Write($"\t{count}. ");
            prece.Izvadīt();
            count++;
        }

        Console.WriteLine("Kopējā summa: " + Kopsumma() + " Eur");
    }
}

public class Persona
{
    public string vards;
    public string parole;
    public Grozs grozs;
    public double lidzekli;

    public void Reģistrēt() //ievadam klases mainīgos un izmantojam groza funkciju lai reģistrētu preces
    {
        grozs = new Grozs();
        Console.Write("Ievadiet jūsu vārdu: ");
        vards = Console.ReadLine();
        Console.Write("Ievadiet jūsu vēlamo paroli: ");
        parole = Console.ReadLine();
        Console.Write("Ievadiet cik jums līdzekļi ir: ");
        lidzekli = double.Parse(Console.ReadLine());
        grozs.Reģistrēt();
    }
    public void PietiekLīdzekļu()
    {
        if(lidzekli >= grozs.Kopsumma())  // Pārbauda, vai ir pietiekami daudz līdzekļu, lai norēķinātos par precēm grozā
        {
            Console.WriteLine("Pietiek Naudas");
        }else
        {
            Console.WriteLine("Nepietiek Naudas");
        }
    }
    public void Izvadīt()
    {
        // Izvada personas vērtības uz ekrāna
        Console.WriteLine($"\tPersona: {vards}");
        Console.WriteLine($"\tPieejamie līdzekļi: {lidzekli} Eur");
        Console.WriteLine($"\tGrozs:");
        grozs.Izvadīt();
    }
}
