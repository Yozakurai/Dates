// uzd1 - Ievadīto skaitli aprēķina ciparu summu ar rekursīvo funckiju


        Console.Write("Ievadiet skaitli: ");
        int skievade = int.Parse(Console.ReadLine());

        int Sum = Rekursijasfun(skievade);

        Console.WriteLine($"Ciparu summa ir {Sum}");


// uzd2 - Programma pieprasa ievadīt atkārtošanas reizes (elementu skaitu), aritmētiskās progresijas soli un progresijas sākuma skaitli. Izmantot rekursīvu funkciju, kas aprēķina aritmētisko progresiju


        Console.Write("Cik elementus izvadīt: ");
        int element = int.Parse(Console.ReadLine());
        Console.Write("Progresijas solis: ");
        int prosolis = int.Parse(Console.ReadLine());
        Console.Write("Progresijas sākums: ");
        int prosakums = int.Parse(Console.ReadLine());
        progresija(element,prosolis,prosakums);

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

static int progresija(int element, int prosolis, int prosakums)
{
    Console.WriteLine(prosakums + prosolis);
    if(element == 1)
    {
        return prosakums;
    }
    else
    {
        return progresija(element - 1, prosolis, prosakums + prosolis);
    }
        
}
