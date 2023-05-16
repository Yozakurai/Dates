myConsole.tagad = Convert.ToString(DateTime.Now);
myConsole.NolasitKaInt();
myConsole.Izvadit("Izvadits tekts");
myConsole.NomainitFonaKrasu();
myConsole.NomainitBurtuKrasu();
myConsole.FormatetVardu("Deivids Saulitis");
myConsole.IzveidotParoli(12);
//myConsole.SifretTekstu("Smirnovs");
myConsole.AtsifretTekstu(myConsole.SifretTekstu("Slepens_vards"));
public class myConsole
{
    public static string tagad; // mainīgajam piešķirt patreizējo datumu. Formātu izvēlēties brīvi
    public static int NolasitKaInt()
    {
        int result;
        Console.Write("Ievadiet veselo skaitli: ");
        string skaitlis = Console.ReadLine();
        if (int.TryParse(skaitlis, out result)) //parbauda vai skaitlis ir skaitlis vai burts.
        {
            Console.WriteLine(result);
            return result;
        }
        else
        {
            Console.WriteLine("Konvertācija bija neveiksmīga");
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
        Random rand = new Random();
        Console.BackgroundColor = (ConsoleColor)rand.Next(16);
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
        for (int i = 0; i < vards_uzvārds.Length; i++)
        {
            if (i == 0)
            {
                Console.Write(vards_uzvārds[i] + ".");
            }
            if (Convert.ToString(vards_uzvārds[i]) == " ")
            {
                for (int j = i; j < vards_uzvārds.Length; j++)
                {
                    Console.Write(vards_uzvārds[j]);
                }
            }

        }
        Console.WriteLine();
        //funkcija saņem vārdu un uzvārdu kā vienu string, piemēram, "Ivars Zars". Un izvada to sekojošā formātā - vārda pirmais burts. Uzvārds (piemēram,"I. Zars")
    }
    public static string IzveidotParoli(int garums)
    {
        string parole = "";
        Random rand = new Random();
        for (int i = 0; i < garums; i++)
        {

            if (i % 2 == 0)
            {
                parole += Convert.ToChar(rand.Next(48, 95));
            }
            else
            {
                if (rand.Next(1, 3) % 2 == 0)
                {
                    parole += Convert.ToChar(rand.Next(40, 63));
                }
                else
                {
                    parole += Convert.ToChar(rand.Next(97, 124));
                }

            }
        }
        Console.WriteLine(parole);
        //funkcija veido un atgriež lietotājam drošo paroli. Paroles garumu funkcija saņem. PAroles veidošanas principus jāizdomā pašam.
        return parole;
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
    public static string AtsifretTekstu(string teksts)
    {
        string atsifrets = "";
        for (int i = 0; i < teksts.Length; i++)
        {
            atsifrets += (char)(teksts[i] - 5);
        }
        Console.WriteLine(atsifrets);
        //funkcija saņem šifrētu tekstu un atšifrē to, izmantojot iepriekš definēto šifrēšanas metodi
        return atsifrets;
    }
}