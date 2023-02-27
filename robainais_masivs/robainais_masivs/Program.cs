
//uzd1
Random rnd1 = new Random();
string[] randoelementi = new string[10];
for(int i = 0; i < 10; i++)
{
    char[] elements = new char[rnd1.Next(4, 18)]; //cik garšs string būs
    for (int x = 0; x < elements.Length; x++)
    {
        int k = rnd1.Next(65, 121); //gadījuma skaitlis no 65-120
        elements[x] = (char)k; //pārveido skaitli uz char
    }
    randoelementi[i] = String.Join("", elements); //apvieno visus char elementus vienā string vērtībā

}
int count = 0;
foreach (string el in randoelementi)
{
    Console.WriteLine($"{count} masīva vērtība ir: {el}"); //izvade
    count++;
}

//uzd2
Console.WriteLine("\n");
Random rnd = new Random();
int[][] robainaismasivs = new int[rnd.Next(2, 9)][]; // izveido masīvu ar gadījuma skaitļu 2-8 rindām

for (int i = 0; i < robainaismasivs.Length; i++) //kolonnas katrā rindā saskaita 
{
    int kolonnasskaits = rnd.Next(4, 11); // izvēlas gadījuma skaitli intervālā no 4 līdz 10
    robainaismasivs[i]  = new int[kolonnasskaits]; // piešķir rindai masīva kolonnasskaits kolonnas

    for (int k = 0; k < kolonnasskaits; k++)
    {
        robainaismasivs[i][k] = rnd.Next(1,11); // aizpilda masīva rindu un kolonnu ar gadījuma skaitli intervālā no 1 līdz 10
    }
}

//izvade masīvu ar 2for cikliem
Console.WriteLine("for cikls: ");
for(int i = 0; i < robainaismasivs.Length;i++)
{
    int k = 0;
    for (k = 0; k < robainaismasivs[i].Length; k++)
    {
        Console.Write($"{robainaismasivs[i][k]}\t");
    }
    Console.WriteLine($"Rindas skaits ir: {i} un garums ir {k}");
}


//izvade masīvu ar 2foreach cikliem
Console.WriteLine("Foreach cikls: ");
int rindskaits = 0;
foreach (int[] sk in robainaismasivs)
{
    int kolskaits = 0;
    foreach (int sk2 in sk)
    {
        Console.Write($"{sk2}\t");
        kolskaits++;
    }
    Console.WriteLine($"Rindas skaits ir: {rindskaits} un garums ir {kolskaits}");
    rindskaits++;
}

//uzd3
Console.WriteLine("Morse for 'deivids'");
string morsekods = ".--. ....- .. ...- .. -.. ..."; // Morse code for "deivids"
string[] morsemas = morsekods.Split(' '); // Sadala mors kodu individuālās daļās kur ir atstarpe

foreach (string morseburts in morsemas)
{
    foreach (char x in morseburts)
    {
        if (x == '.') //īss pīkstiens ar .
        {
            Console.Beep(500, 100);
        }
        else if (x == '-') //garšs pīkstiens prieks -
        {
            Console.Beep(500, 800);
        }
    }

    System.Threading.Thread.Sleep(100); // pauze
}