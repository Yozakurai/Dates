// uzd1 - Ievadīto skaitli aprēķina ciparu summu ar rekursīvo funckiju
internal static class RekursijaHelpers
{
    public static void Main(string[] args)
    {
        Console.Write("Ievadiet skaitli: ");
        int skievade = int.Parse(Console.ReadLine());

        int Sum = Rekursijasfun(skievade);

        Console.WriteLine($"Ciparu summa ir {Sum}");

    }

    static int Rekursijasfun(int skievade)
    {
        if (skievade == 0) //Ja skaitlis ir 0, tad izvada 0
        {
            return 0;
        }
        else //Ja nav = 0, tad aprēķina skaitli
        {
            return skievade % 10 + Rekursijasfun(skievade / 10); //ievadīto pēdējo skaitli saskaitam ar funkciju, kas izsauc sevi ar skaitli, kas iegūts, dalot 'skievade' ar 10.
                                                                 //Šī funkcija tiek izsaukta ar jaunu skaitli(skievade / 10) tik ilgi, kamēr skaitlis ir lielāks par 0.
        }
    }
}