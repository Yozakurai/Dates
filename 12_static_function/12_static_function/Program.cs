using System;
using System.Drawing;
using System.Text;

public class myConsole
{
    static string tagad = DateTime.Now.ToString("dd.MM.yyyy"); // mainīgajam piešķirt patreizējo datumu. Formātu izvēlēties brīvi
 static int NolasitKaInt()
    {
        //funkcija pieprasa lietotājam ievadīt veselo skaitli. Gadījumā, ja
        //lietotājs ievada veselo skaitli, atgriež to.Ja lietotājs ievadīja ne veselo
        //skaitli(burtus, simbolus) atgriež nulli un paziņo, ka konvertācija bija
        //neveiksmīga.

        int ievade;
        bool numurs = int.TryParse(Console.ReadLine(), out ievade);
        if(numurs)
        {
            return ievade;
        }
        else
        {
            Console.WriteLine("Konvertācija bija neveiksmīga...");
            return 0;
        }
    }
    static void Izvadit(string text)
    {
        Console.WriteLine(text);
        //funkcija izvada tekstu text
    }
    static void NomainitFonaKrasu()
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
    static void NomainitBurtuKrasu()
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
    static void FormatetVardu(string vards_uzvārds)
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
    static string IzveidotParoli(int garums)
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
    static string SifretTekstu(string teksts)
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
    static string AtsifretTekstu(string teksts)
    {
        //funkcija saņem šifrētu tekstu un atšifrē to, izmantojot iepriekš
        //definēto šifrēšanas metodi
        string atsifrejums = "";
        foreach (char burts in teksts)
        {
            char atsifretaisBurts = (char)(burts - 1);
            atsifrejums += atsifretaisBurts;
        }
        return atsifrejums;
    }
}