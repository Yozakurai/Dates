
/// 1uzd
string ievade = "";
string izvade = "";
string izvade11 = "";
int count=0;
string[] masivs = new string[10];
while(count<10)
{
    Console.Write("Ievadiet {0} masīva vērtību: ", count+1);
    ievade = Console.ReadLine();
    masivs[count] = ievade;
    count++;
}
for (count = 0; count < masivs.Length; count++)
{
    izvade += masivs[count];
    izvade11 = masivs[count];
    Console.WriteLine("Masīva {0} vērtība ir: {1}", count+1, izvade11);
}
Console.WriteLine("Kopējā izvade: {0}", izvade);
Console.WriteLine("");

///2uzd
Console.Write("Ievadiet pirmā masīva izmēru: ");
int mas1 = int.Parse(Console.ReadLine());
var masivais1 = new string[mas1];
Console.Write("Ievadiet otrā masīva izmēru: ");
int mas2 = int.Parse(Console.ReadLine());
var masivais2 = new string[mas2];
string masivais1add;
string masivais2add;
for (count = 0; count < mas1; count++) /////1 masivais  IEVADE
{
    Console.Write("Ievadiet 1. masīva {0} masīva vērtību: ", count + 1);
    masivais1add = Console.ReadLine();
    masivais1[count] = masivais1add;

}
for (count = 0; count < mas2; count++) ////2 masivais  IEVADE
{
    Console.Write("Ievadiet 2. masīva {0} masīva vērtību: ", count+1);
    masivais2add = Console.ReadLine();
    masivais2[count] = masivais2add;

}
for (count = 0; count < masivais1.Length; count++)   ////IZVADE
{
    string masivaizvade = masivais1[count];
    Console.WriteLine("1. masīva {0} vērtība ir: {1}", count+1, masivaizvade);
}
for (count = 0; count < masivais2.Length; count++)  ////IZVADE
{
    string masivaizvade = masivais2[count];
    Console.WriteLine("2. masīva {0} vērtība ir: {1}", count + 1, masivaizvade);
}

count = 0;
string izvade1 = "";
if(masivais1.Length<masivais2.Length) /// IF masivais1 ir mazaks par masivo2 pildas
{
     for (count = 0; count < masivais1.Length; count++)
            izvade1 += masivais1[count] + masivais2[count];
            if (count < masivais2.Length)
            {
            for (; count < masivais2.Length; count++)
                izvade1 += masivais2[count];
            }
}
else                                    /// IF masivais1 ir lielaks par masivo2 pildas
{
    for (count = 0; count < masivais2.Length; count++)
            izvade1 = izvade1 + masivais1[count] + masivais2[count];
        if (count < masivais1.Length)
        {
            for (; count < masivais1.Length; count++)
                izvade1 = izvade1 + masivais1[count];
        }

}

Console.WriteLine("1. un 2. masiva apvienota simbolu virkne: {0}", izvade1);

Console.WriteLine("");


///uzd3
Console.Write("Ievadiet pirmā masīva izmēru: ");
int mass1 = int.Parse(Console.ReadLine());
var masivaiss1 = new string[mass1];
Console.Write("Ievadiet otrā masīva izmēru: ");
int mass2 = int.Parse(Console.ReadLine());
var masivaiss2 = new string[mass2];
string masivaiss1add;
string masivaiss2add;
for (count = 0; count < mass1; count++) /////1 masivais  IEVADE
{
    Console.Write("Ievadiet 1. masīva {0} masīva vērtību: ", count + 1);
    masivaiss1add = Console.ReadLine();
    masivaiss1[count] = masivaiss1add;

}
for (count = 0; count < mass2; count++) ////2 masivais  IEVADE
{
    Console.Write("Ievadiet 2. masīva {0} masīva vērtību: ", count + 1);
    masivaiss2add = Console.ReadLine();
    masivaiss2[count] = masivaiss2add;

}
for (count = 0; count < masivaiss1.Length; count++)   ////IZVADE
{
    string masivaizvade = masivaiss1[count];
    Console.WriteLine("1. masīva {0} vērtība ir: {1}", count + 1, masivaizvade);
}
for (count = 0; count < masivaiss2.Length; count++)  ////IZVADE
{
    string masivaizvade = masivaiss2[count];
    Console.WriteLine("2. masīva {0} vērtība ir: {1}", count + 1, masivaizvade);
}

int divide = masivaiss1.Length / 2;
string rezultaats = "";
for (count = 0; count < masivaiss1.Length; count++)
{
    if (count == divide)
    {
        foreach (string pluss in masivaiss2)
        {
            rezultaats += pluss;
        }
    }
    rezultaats += masivaiss1[count];
}


Console.Write("1. un 2. masīva apvienotā vērtība ir: {0}", rezultaats);

