

/*
Calculator objekts = new Calculator();
Console.WriteLine("Ievadiet x un y: ");
int x, y;
string X = Console.ReadLine();
string Y = Console.ReadLine();
int.TryParse(X, out x);
int.TryParse(Y, out y);
Console.WriteLine($"x vertiba: {x}");
Console.WriteLine($"x vertiba: {y}");
objekts.Kapinat(ref x);
Console.WriteLine($"Kapinat: {x} ");
int.TryParse(X, out x);
objekts.Reizinat(ref x, ref y);
Console.WriteLine($"Reizinat: {x}");
*/
Console.WriteLine("\n2.uzd\n");
// 2.uzdevums
Console.WriteLine("Cik daudz skaitļu būs masīva:");
int skaits = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadiet masiva vertibas: ");
int[] values = new int[skaits];
for (int i = 0; i < skaits; i++)
{
    values[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Min: {MansMath.Min(values)}");
Console.WriteLine($"Max: {MansMath.Max(values)}");
Console.WriteLine($"Min: {MansMath.Min(2, 3, 5, 1, 6, 8, 3)}");
Console.WriteLine($"Max: {MansMath.Max(2, 3, 5, 1, 6, 8, 3)}");

Console.WriteLine("\n3.uzd\n");

Console.WriteLine("Ievadiet masīva garumu:");
skaits = int.Parse(Console.ReadLine());
int[] mas = new int[skaits];
Random rand = new Random();
for (int i = 0; i < skaits; i++)
{
    mas[i] = rand.Next(1, 11);
}
int Skaits;
Console.WriteLine($"Para skaitla summa: {ParaSkaitluSumma(mas, out Skaits)}"); //izvada para skaitlu summu
Console.WriteLine($"Para skaitla skaits {Skaits}"); //izvada para skaitlu skaitu

static int ParaSkaitluSumma(int[] mas, out int paraSkaitluSkaits)
{
    paraSkaitluSkaits = 0;
    int summa = 0;
    foreach (int n in mas)
    {
        if (n % 2 == 0)
        {
            Console.Write($"{n} ");
            summa += n;
            paraSkaitluSkaits++;
        }
    }
    return summa;
    //return paraSkaitluSkaits;
}
//1.uzd
public class Calculator
{
    public void Kapinat(ref int x)
    {
        x = (int)Math.Pow(x, -1 / x);
    }
    public void Reizinat(ref int x, ref int y)
    {
        x = x * y;
    }
}
//2.uzd

public class MansMath
{
    public static int Min(params int[] values)
    {
        int min = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }
        return min;
    }
    public static int Max(params int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }
}