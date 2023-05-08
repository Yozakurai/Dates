using System;
using System.Drawing;
using System.Text;


Console.WriteLine("int ievade...");
    Console.Write("Ievadiet skaitli: ");
    myConsole.NolasitKaInt();

Console.WriteLine("izvade...");
    myConsole.Izvadit("Funkcija izvada tekstu");

Console.WriteLine("Background...");
//myConsole.NomainitFonaKrasu();

Console.WriteLine("Burtu krasa...");
//myConsole.NomainitBurtuKrasu();

//Console.WriteLine("formatesana...");
//myConsole.FormatetVardu("Skaists_Vārds");

Console.WriteLine("Parole...");
myConsole.IzveidotParoli(18);

Console.WriteLine("Šifrēšana...");
Console.WriteLine("Ievadiet tekstu ko vēlaties šifrēt");
    string teksts = Console.ReadLine();
    string protect = myConsole.SifretTekstu(teksts);
    Console.WriteLine("atsifrejums...");
    myConsole.AtsifretTekstu(protect);

public class myConsole
{
    static string tagad = DateTime.Now.ToString("dd.MM.yyyy"); // mainīgajam piešķirt patreizējo datumu. Formātu izvēlēties brīvi
 public static int NolasitKaInt()
    {
        //funkcija pieprasa lietotājam ievadīt veselo skaitli. Gadījumā, ja
        //lietotājs ievada veselo skaitli, atgriež to.Ja lietotājs ievadīja ne veselo
        //skaitli(burtus, simbolus) atgriež nulli un paziņo, ka konvertācija bija
        //neveiksmīga.
        int result;
        string skaitlis = Console.ReadLine();
        if (int.TryParse(skaitlis, out result))
        {
            Console.WriteLine(result);
            return result;
        }
        else
        {
            Console.WriteLine("Konvertācija bija neveiksmīga...");
            return 0;
        }
    }
    public static void Izvadit(string text)
    {
        Console.WriteLine(text);
        //funkcija izvada tekstu text
    }
    public static void NomainitFonaKrasu()
    {
        Random random = new Random();
        int r = random.Next(0, 255);
        int g = random.Next(0, 255);
        int b = random.Next(0, 255);
        Color color = Color.FromArgb(r, g, b);
        ConsoleColor consoleColor = (ConsoleColor)Array.IndexOf(Enum.GetValues(typeof(ConsoleColor)), Enum.Parse(typeof(ConsoleColor), color.Name)); //parveido no System.Drawing.Color
                                                                                                                                                     //uz lasāmu System.CosnoleColor
        Console.BackgroundColor = consoleColor;
        //funkcija nomaina konsoles fona krāsu uz gadījuma (!) krāsu
    }
    public static void NomainitBurtuKrasu()
    {
        Random random = new Random();
        int r = random.Next(0, 255);
        int g = random.Next(0, 255);
        int b = random.Next(0, 255);
        Color color = Color.FromArgb(r, g, b);
        ConsoleColor consoleColor = (ConsoleColor)Array.IndexOf(Enum.GetValues(typeof(ConsoleColor)), Enum.Parse(typeof(ConsoleColor), color.Name)); //parveido no System.Drawing.Color
                                                                                                                                                     //uz lasāmu System.CosnoleColor
        Console.ForegroundColor = consoleColor;
        //funkcija nomaina konsoles burtu krāsu uz gadījuma (!) krāsu
    }
    public static void FormatetVardu(string vards_uzvārds)
    {
        // Sākumā sadalam vārdu un uzvārdu atsevišķos string objektos.
        string[] splitVardsUzvards = vards_uzvārds.Split(' ');
        string vards = splitVardsUzvards[0];
        string uzvards = splitVardsUzvards[1];

        // Izvadam formēto vārdu un uzvārdu.
        Console.WriteLine($"{vards.Substring(0, 1)}. {uzvards}");

        //funkcija saņem vārdu un uzvārdu kā vienu string, piemēram, "Ivars
        //Zars". Un izvada to sekojošā formātā - vārda pirmais burts. Uzvārds (piemēram,
        //"I. Zars")
    }
    public static string IzveidotParoli(int garums)
    {
        const string simboli = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{};:,.<>/?";
        StringBuilder parolesBuilder = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < garums; i++)
        {
            int randomSimbolaIndekss = random.Next(0, simboli.Length - 1);
            char randomSimbols = simboli[randomSimbolaIndekss];
            parolesBuilder.Append(randomSimbols);
        }

        return parolesBuilder.ToString();
        //funkcija veido un atgriež lietotājam drošo paroli. Paroles garumu
        //    funkcija saņem. PAroles veidošanas principus jāizdomā pašam.
    }
    public static string SifretTekstu(string teksts)
    {
        //funkcija saņem kādu tekstu un šifrē to, izmantojot kādu no
        //vienkāršākiem šifrēšanas metodēm(piemēram, katram simbolam tiek pieskaitīs
        //kāds skaitlis)
        string sifrejums = "";
        foreach (char burts in teksts)
        {
            char sifretaisBurts = (char)(burts + 1);
            sifrejums += sifretaisBurts;
        }
        return sifrejums;
    }
    public static string AtsifretTekstu(string sifrejums)
    {
        //funkcija saņem šifrētu tekstu un atšifrē to, izmantojot iepriekš
        //definēto šifrēšanas metodi
        string atsifrejums = "";
        foreach (char burts in sifrejums)
        {
            char atsifretaisBurts = (char)(burts - 1);
            atsifrejums += atsifretaisBurts;
        }
        return atsifrejums;
    }
}