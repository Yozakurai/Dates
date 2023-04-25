
Console.Write("Ievadiet klašu daudzumu: ");
int Klases_daudzums = Convert.ToInt32(Console.ReadLine());
Klase[] klases;
klases = new Klase[Klases_daudzums];

for (int i = 0; i < Klases_daudzums; i++) // klases registrēšana
{
    klases[i] = new Klase();
    klases[i].Registret();
}
for (int i = 0; i < Klases_daudzums; i++) // izvada visu info par klasēm
{
    klases[i].Izvadit();
}


// Izvēlne
bool iziet = false;
do 
{
    Console.WriteLine("\nIzvelaties, ko jus velaties:");
    Console.WriteLine("1 - Izveidot jaunas klases\n2 - Izvadit informaciju par klasem\n3 - Atrast konkretu klasi\n4 - Sameklet konkretu skolenu\n5 - Konkreta klase sameklet visvecako skolenu\nexit - iziet");
    string izvelne = Console.ReadLine();
    if (izvelne == "1") //ļauj izveidot jaunās klases
    {
        Console.Write("Ievadiet klašu daudzumu: ");
        int extra = Convert.ToInt32(Console.ReadLine()); //ievadam cik daudz jaunas klases izveidosim

        for (int i = Klases_daudzums; i < Klases_daudzums + extra; i++) // sākam aizpildīt paplašināto masīvu no pēdējās reģistrētās klases
        {
            klases[i] = new Klase();
            klases[i].Registret();
        }
        Klases_daudzums = extra + Klases_daudzums;
    }
    else if (izvelne == "2") //izvadīt info par klasēm
    {
        foreach (Klase n in klases)
        {
            n.Izvadit();
        }

    }
    else if (izvelne == "3") //izvadīt info par konkrētu klasi
    {
        Console.Write("\n\nAtrast specificēto klasi: ");
        string atrast_klasi = Console.ReadLine();
        foreach (Klase klass in klases) 
        {
            if (klass.Nosaukums == atrast_klasi)
            {
                klass.Izvadit(); // izvada informāciju par atrastu klasi, ja klase tika atrasta
            }
        }

    }
    else if (izvelne == "4") //izvadīt infor par skolēnu
    {
        Console.Write("\n\nIevadiet skolēna vārdu vai uzvārdu, kuru vēlaties atrast: ");
        string find_skolens = Console.ReadLine();
        foreach (Klase skaits in klases)
        {
            skaits.Meklet_skolenu(find_skolens);
        }

    }
    else if (izvelne == "5") //atrast visvecāko skolēnu un informāciju par viņu 
    {
        Console.Write("Ievadiet klases nosaukumu: ");
        string atrast_klasi = Console.ReadLine();
        foreach (Klase skaits in klases) 
        {
            if (skaits.Nosaukums == atrast_klasi)
            {
                skaits.Vecakais_skolens();
            }
        }
    }
    else if (izvelne == "exit")
    {
        iziet = true;
    }
} while (iziet != true);

class Skolens
{
    public string Vards;
    public string Uzvards;
    public string Pers_kods;
    public void Registret() //inicializē vienu skolēnu, pieprasa ievadīt vārdu, uzvārdu un personas kodu
    {
        Console.Write("Ievadiet skolēna vārdu: ");
        Vards = Console.ReadLine();
        Console.Write("Ievadiet skolēna uzvārdu: ");
        Uzvards = Console.ReadLine();
        Console.Write("Ievadiet skolēna personas kodu: ");
        Pers_kods = Console.ReadLine();

    }
    public void Izvadit()
    {
        Console.WriteLine($"\nSkolēna vārds: {Vards}\nSkolēna uzvārds: {Uzvards}\nPersonas kods: {Pers_kods}\nVecums: {Aprekinat_vecumu()}");
    }
    public int Aprekinat_vecumu()
    {
        string dzg;
        string g = Pers_kods.Substring(4, 2);
        string t = Pers_kods.Substring(7, 1);
        if (t == "1")
        {
            dzg = 19 + g; //aprēķinās dzimšanas gads
            int age = DateTime.Now.Year - Convert.ToInt32(dzg); //no tagadējā gada atņems skolēna dzimšanas gads
            return age; //atgriež vērtību 
        }
        else
        {
            dzg = 20 + g; 
            int age = DateTime.Now.Year - Convert.ToInt32(dzg); 
            return age; 
        }
    }
}
class Skolotajs
{
    public string Vards;
    public string Uzvards;
    public double Alga;
    public void Registret()
    {
        Console.Write("Ievadiet skolotāja vārdu: ");
        Vards = Console.ReadLine();
        Console.Write("Ievadiet skolotāja uzvārdu: ");
        Uzvards = Console.ReadLine();
        Console.Write("Ievadiet skolotāja algu: ");
        Alga = Convert.ToDouble(Console.ReadLine());
    }
    public void Izvadit()
    {
        Console.WriteLine($"\nSkolotājs:\nVārds: {Vards}\nUzvārds: {Uzvards}\nAlga: {Alga}\nAlga pēc nodokļiem: {Alga_pec_nodokliem()}");
    }
    public double Alga_pec_nodokliem() //izreizina algu
    {
        double alga_pec_nodokliem = 0;
        if (Alga <= 500.00)
        {
            return alga_pec_nodokliem = Alga; // ja alga mazāk par min algu, tad nodokļi netiek atskaitīti
        }
        else
        {
            return alga_pec_nodokliem = Alga - (Alga * 0.20); //ja alga ir lielāka par minimālo algu, tad tiek atņemts nodoklis 
        }
    }
}
class Klase
{
    public string Nosaukums;
    public int Skolenu_skaits;
    public Skolens[] Skoleni;
    public Skolotajs Klases_audzinatajs;
    public void Registret()
    {
        Console.Write("\nIevadiet klases nosaukumu: ");
        Nosaukums = Console.ReadLine();
        Console.Write("Ievadiet datus par klases audzinātāju...\n\n");
        Klases_audzinatajs = new Skolotajs(); //inicializē jaunu skolotāju klasei
        Klases_audzinatajs.Registret();
        Console.Write("\nIevadiet skolēnu skaitu: ");
        Skolenu_skaits = Convert.ToInt32(Console.ReadLine());
        Skoleni = new Skolens[Skolenu_skaits];
        for (int i = 0; i < Skolenu_skaits; i++) // inicializē skolēni 
        {
            Skoleni[i] = new Skolens();
            Skoleni[i].Registret();
        }
    }
    public void Izvadit() //izvada informāciju par klasi un tiem, kas tai pieder
    {
        Console.WriteLine($"Klases nosaukums: {Nosaukums}");
        Klases_audzinatajs.Izvadit();
        Console.WriteLine("\nSkoleni:");
        foreach (Skolens n in Skoleni) //Izvada info par skolēniem
        {
            n.Izvadit();
        }
    }
    public void Vecakais_skolens()
    {
        Skolens vecakais = Skoleni[0];
        int vecums = 0;
        for (int i = 0; i < Skolenu_skaits; i++)
        {

            if (vecums < Skoleni[i].Aprekinat_vecumu()) //salīdzina skolēna vecumu ar 0
            {
                vecums = Skoleni[i].Aprekinat_vecumu(); // ja skolēns ir vecāks par iepriekšējo, tad viņa vecums būs piešķirts definīcijai vecums
                vecakais = Skoleni[i]; // definīcija vecakais piešķiras skolēns ar visiem viņa datiem, lai turpmāk izvadītu tos
            }
        }
        Console.Write($"\nVisvecākais skolens ir {vecums} vecs");
        vecakais.Izvadit(); // izvada info par vecāko skolēni
    }
    public void Meklet_skolenu(string find_skolens)
    {
        foreach (Skolens n in Skoleni) 
        {
            if (find_skolens == n.Vards)// ja vārds būs = ar skolēna vārdu, tad tiek izvadita info par to skolēnu
            {
                n.Izvadit(); 
                Console.WriteLine($"Klase: {Nosaukums}");
            }
            else if (find_skolens == n.Uzvards)
            {
                n.Izvadit(); // ja vārds būs = ar skolēna vārdu, tad tiek izvadita info par to skolēnu
                Console.WriteLine($"Klase: {Nosaukums}");
            }
            else
            {
                Console.WriteLine("Tāds skolēns nav pieriģstrēts");
            }
        }
    }
}
