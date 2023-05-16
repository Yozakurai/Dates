//Izveidot klasi StudijuKurss ar public īpašībām:
//  • Nosaukums string tipa;
//  • Kredītpunkti int tipa;
//  • EKredītpunkti double(izmantojot get – Kredītpunkti * 1, 5)
//  • IrObligāts bool tipa;
//Izveidot klasei StudijuKurss funkcijas:
//  • ReadData() – nolasa no klaviatūras klases īpašību vērtības (izņemot
//EKredītpunkti);
//  • PrintData() – izvada klases vērtības uz ekrāna;
//
//Program klases funkcijas
//  • FillArray(StudijuKurss[] kurss)-aizpilda masīvu ar vērtībām (izmantojot klases StudijuKurss funkciju ReadData());
//  • PrintArray(StudijuKurss[] kurss) – saņem kā parametru StudijuKurss tipa masīvu un izvada visus masīva vērtības uz ekrāna (izmantojot klases StudijuKurss funkciju PrintData());
//  • PrintArrayToFile(StudijuKurss[] kurss) – saņem kā parametru StudijuKurss tipa masīvu un saglabā masīva vērtības .txt failā, kur katru īpašību atdala ar „ ; ” vai citu simbolu;
//  • StudijuKurss[] ReadArrayFromFile() – nolasa saglabāto.txt failu un saglāba vērtības StudijuKurss tipa masīvā (StudijuKurss[]). Pirms aizpildīt masīvu ar
//    vērtībām ir nepieciešams noskaidrot masīva garumu, jo pirms nolasīšanas elementu skaits nav zināms! Funkcija atgriež StudijuKurss tipa masīvu!
//Funkcijā Main():
//  • Izveidot pirmo StudijuKurss tipa masīvu (StudijuKurss[]);
//  • Aizpildīt masīvu ar vērtībām (funkcija FillArray()) un ierakstīt.txt failā (funkcija PrintArrayToFile());
//  • Izveidot otro StudijuKurss tipa masīvu (StudijuKurss[]);
//  • Nolasīt no faila informāciju uz otro masīvu (funkcija ReadArrayFromFile()) un izvadīt uz ekrāna otra masīva vērtības (funkcija PrintArray());

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****************************************************1UZD*****************************************************");
        // Izveidojam pirmo StudijuKurss masīvu un aizpildām to ar vērtībām
        StudijuKurss[] kurss1 = new StudijuKurss[3];
        FillArray(kurss1);

        // Izvadam pirmo masīvu uz ekrāna un saglabājam to failā
        PrintArray(kurss1);
        PrintArrayToFile(kurss1);

        // Izveidojam otro StudijuKurss masīvu un nolasa vērtības no faila
        StudijuKurss[] kurss2 = ReadArrayFromFile();

        // Izvadam otro masīvu uz ekrāna
        PrintArray(kurss2);
    }
    static void FillArray(StudijuKurss[] kurss)
    {
        for (int i = 0; i < kurss.Length; i++)
        {
            Console.WriteLine($"Ievadiet {i + 1}. kursa datus:");
            kurss[i] = new StudijuKurss();
            kurss[i].ReadData();
        }
    }

    static void PrintArray(StudijuKurss[] kurss)
    {
        for (int i = 0; i < kurss.Length; i++)
        {
            kurss[i].PrintData();
        }
    }

    static void PrintArrayToFile(StudijuKurss[] kurss)
    {
        using (StreamWriter writer = new StreamWriter("kursi.txt"))
        {
            for (int i = 0; i < kurss.Length; i++)
            {
                writer.WriteLine($"Nosaukums: {kurss[i].Nosaukums}\nKredīts: {kurss[i].Kreditpunkti}\nEkreditpunkti: {kurss[i].EKreditpunkti}\nObligāts?: {(kurss[i].IrObligats ? "jā" : "nē")}\n");
            }
        }
    }

    //static StudijuKurss[] ReadArrayFromFile()
    //{
    //    StreamReader sr = new StreamReader("kursi.txt");
    //    int count = 0;
    //    while (sr.ReadLine() != null)
    //    {
    //        count++;
    //    }
    //    sr.Close();

    //    StudijuKurss[] kurss = new StudijuKurss[count];
    //    sr = new StreamReader("kursi.txt");
    //    for (int i = 0; i < count; i++)
    //    {
    //        string[] data = sr.ReadLine().Split(';');
    //        kurss[i] = new StudijuKurss();
    //        kurss[i].Nosaukums = data[0];
    //        kurss[i].Kreditpunkti = int.Parse(data[1]);
    //        kurss[i].EKreditpunkti = double.Parse(data[2]);
    //        kurss[i].IrObligats = bool.Parse(data[3]);

    //    }
    //    sr.Close();

    //    return kurss;
    //}

}
class StudijuKurss
{
    public string Nosaukums;
    public int Kreditpunkti;
    public double EKreditpunkti { get { return Kreditpunkti * 1.5; } set { } }
    public bool IrObligats;
    public void ReadData()
    {
        Console.Write("Ievadiet kursa nosaukumu: ");
        Nosaukums = Console.ReadLine();

        Console.Write("Ievadiet kredītpunktu skaitu: ");
        Kreditpunkti = int.Parse(Console.ReadLine());

        Console.Write("Vai kursa kredītpunkti ir obligāti? (y/n): ");
        string input = Console.ReadLine();
        if (input == "y" || input == "yes" )
        {
            IrObligats = true;
        }else
        {
            IrObligats = false;
        }
    }
    public void PrintData()
    {
        Console.WriteLine($"\nKurss: {Nosaukums}\nKredītpunkti: {Kreditpunkti}\n E-Kredītpunkti: {EKreditpunkti}\nObligāts: {(IrObligats ? "Ja" : "Ne")}");
    }
}

