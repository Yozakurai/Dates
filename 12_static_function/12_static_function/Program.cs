using System;
using System.Drawing;
using System.Text;


Console.WriteLine("int ievade...");
Console.Write("ievadiet skaitli: ");
myConsole.NolasitKaInt();

Console.WriteLine("izvade...");
myConsole.Izvadit("funkcija izvada tekstu");

Console.WriteLine("background...");
myConsole.NomainitFonaKrasu();

Console.WriteLine("burtu krasa...");
myConsole.NomainitBurtuKrasu();

Console.WriteLine("formatesana...");
myConsole.FormatetVardu("Skaists Vārds");

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
        Console.BackgroundColor = (ConsoleColor)random.Next(16);
        //funkcija nomaina konsoles fona krāsu uz gadījuma (!) krāsu
    }
    public static void NomainitBurtuKrasu()
    {
        Random rand = new Random();
        Console.ForegroundColor = (ConsoleColor)rand.Next(16);
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
        Console.WriteLine(parolesBuilder);
        return parolesBuilder.ToString();
        //funkcija veido un atgriež lietotājam drošo paroli. Paroles garumu
        //    funkcija saņem. PAroles veidošanas principus jāizdomā pašam.
    }
    public static string SifretTekstu(string teksts)
    {
        string sifrets = "";
        for (int i = 0; i < teksts.Length; i++)
        {
            sifrets += (char)(teksts[i] + 5);
        }
        Console.WriteLine(sifrets);
        //funkcija saņem kādu tekstu un šifrē to, izmantojot kādu no vienkāršākiem šifrēšanas metodēm(piemēram, katram simbolam tiek pieskaitīs kāds skaitlis)
        return sifrets;
    }
    public static string AtsifretTekstu(string protect)
    {
        string atsifrets = "";
        for (int i = 0; i < protect.Length; i++)
        {
            atsifrets += (char)(protect[i] - 5);
        }
        Console.WriteLine(atsifrets);
        //funkcija saņem šifrētu tekstu un atšifrē to, izmantojot iepriekš definēto šifrēšanas metodi
        return atsifrets;
    }
}
