using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
///1uzd
Console.WriteLine("*********************************************************1 UZD*********************************************************");
int[] numbers = new int[10];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++) // aizpilda masīvu ar gadījuma skaitļiem no 1 līdz 9
{
    numbers[i] = rand.Next(1, 10); 
}
Console.WriteLine("Gadījuma skaitļi: ");
foreach(int x in numbers) //izvada
{
    Console.Write(x + " ");
}

int count = 0;
for (int i = 0; i < numbers.Length - 1; i++) //sakārto masīvu ar burbuļa kārtošanu
{
    for (int j = i + 1; j > 0; j--)
    {
        if (numbers[j - 1] > numbers[j]) // apmaina elementus vietām
        {
            int temp = numbers[j - 1];
            numbers[j - 1] = numbers[j];
            numbers[j] = temp;

            count++;
        }
    }
   
}

Console.WriteLine("\n Augošā secībā...");
for (int i = 0; i < numbers.Length; i++) //izvada ar zvaigznēm
{
    Console.Write(numbers[i] + " = ");
    for (int j = 0; j < numbers[i]; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nVajadzēja {count} reizes, lai pabeigtu darbību...\n");



count = 0;
for (int i = 0; i < numbers.Length; i++) // aizpilda masīvu ar gadījuma skaitļiem no 1 līdz 9
{
    numbers[i] = rand.Next(1, 10);
}

for (int i = 0; i < numbers.Length - 1; i++) // dilstošā secībā burbuļa kārtošana
{
    for (int j = i + 1; j > 0; j--)
    {
        if (numbers[j - 1] < numbers[j])
        {
            int temp = numbers[j - 1];
            numbers[j - 1] = numbers[j];
            numbers[j] = temp;
            count++;
        }
    }
}
Console.WriteLine("Gadījuma skaitļi: ");
foreach (int x in numbers) //izvada
{
    Console.Write(x + " ");
}
Console.WriteLine("\n Dilstošā secībā");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " = ");
    for (int j = 0; j < numbers[i]; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nVajadzēja {count} reizes, lai pabeigtu darbību...\n");


////
//10 vērtības
////
int total = 0;
count = 0;
for (int k = 0; k < 10; k++)
{
    int[] num = new int[10];
    for (int i = 0; i < num.Length; i++) // aizpilda masīvu ar gadījuma skaitļiem no 1 līdz 9
    {
        num[i] = rand.Next(1, 10);
    }


    for (int i = 0; i < num.Length - 1; i++) //sakārto masīvu ar burbuļa kārtošanu
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (num[j - 1] > num[j]) // apmaina elementus vietām
            {
                int temp = num[j - 1];
                num[j - 1] = num[j];
                num[j] = temp;

                count++;
            }
        }

    }

    total += count;
}
double average = (double)total / 10;
Console.WriteLine("Vidējais 10 darbību skaits ar masīvu, kuram ir 10 elementi: " + average);

////
//50 vērtības
////
total = 0;
count = 0;
for (int k = 0; k < 10; k++)
{
    int[] n = new int[50];
    for (int i = 0; i < n.Length; i++) // aizpilda masīvu ar gadījuma skaitļiem no 1 līdz 9
    {
        n[i] = rand.Next(1, 10);
    }


    for (int i = 0; i < n.Length - 1; i++) //sakārto masīvu ar burbuļa kārtošanu
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (n[j - 1] > n[j]) // apmaina elementus vietām
            {
                int temp = n[j - 1];
                n[j - 1] = n[j];
                n[j] = temp;

                count++;
            }
        }

    }

    total += count;
}
average = 0;
average = (double)total / 10;
Console.WriteLine("Vidējais 10 darbību skaits ar masīvu, kuram ir 50 elementi: " + average);
Console.WriteLine("*********************************************************2 UZD*********************************************************");
//uzd2
// * Inicializēt masīvu ar desmit elementiem un aizpildīt to ar gadījuma skaitļiem;
// * Sakārtot masīvu, izmantojot Insert Sort kārtošanas algoritmu, pieaugošā secībā;
// * Pie masīva izvadīšanas atkarībā no skaitļa vērtības izvadīt to ar zvaigznītēm, piemēram, 3 = *** un 5 = *****;
// * Sakārtotā masīva vērtības inicializēt ar jaunām gadījumu skaitļu vērtībām;
// * Sakārtot masīvu, izmantojot Insert Sort kārtošanas algoritmu, dilstošās secībā;
// * Pie masīva izvadīšanas atkarībā no skaitļa vērtības izvadīt to ar zvaigznītēm, piemēram, 3 = *** un 5 = *****;
// * Pielikt skaitītāju, kas sakaita nepieciešamo darbību skaitu līdz masīvs tiek sakārtots;
// * Veikt 10 testus ar masīvu, kuram ir 10 elementi un apskatīt vidējo rezultātu;
// * Veikt 10 testus ar masīvu, kuram ir 50 elementi un apskatīt vidējo rezultātu;

int[] c = new int[10];
for (int i = 0; i < c.Length; i++)
{
    c[i] = rand.Next(1, 10); // gadījuma skaitlis no 1 līdz 9
}
Console.WriteLine("Gadījuma skaitļi: ");
foreach (int x in c) //izvada
{
    Console.Write(x + " ");
}

count = 0;
int index;
for (int i = 1; i < c.Length; i++)
{
    index = c[i];
    int j = i;
    while (j > 0 && c[j - 1] > index)
    {
        c[j] = c[j - 1];
        j = j - 1;
        count++;
    }
    c[j] = index;
}

Console.WriteLine("\n Augošā secībā...");
for (int i = 0; i < c.Length; i++) //izvada ar zvaigznēm
{
    Console.Write(c[i] + " = ");
    for (int j = 0; j < c[i]; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nVajadzēja {count} reizes, lai pabeigtu darbību...\n");

for (int i = 0; i < c.Length; i++)
{
    c[i] = rand.Next(1, 10); // gadījuma skaitlis no 1 līdz 9
}

Console.WriteLine("Gadījuma skaitļi: ");
foreach (int x in c) //izvada
{
    Console.Write(x + " ");
}
count = 0;
for (int i = 1; i < c.Length; i++)
{
    index = c[i];
    int j = i;
    while (j > 0 && c[j - 1] < index)
    {
        c[j] = c[j - 1];
        j = j - 1;
        count++;
    }
    c[j] = index;
}
Console.WriteLine("\n Dilstošā secībā...");
for (int i = 0; i < c.Length; i++) //izvada ar zvaigznēm
{
    Console.Write(c[i] + " = ");
    for (int j = 0; j < c[i]; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nVajadzēja {count} reizes, lai pabeigtu darbību...\n");

///
//10 vērtības
///
count = 0;
total = 0;
for (int k = 0; k < 10; k++)
{
    for (int i = 0; i < c.Length; i++)
    {
        c[i] = rand.Next(1, 10); // gadījuma skaitlis no 1 līdz 9
    }
    for (int i = 1; i < c.Length; i++)
    {
        index = c[i];
        int j = i;
        while (j > 0 && c[j - 1] > index)
        {
            c[j] = c[j - 1];
            j = j - 1;
            count++;
        }
        c[j] = index;
    }
    total += count;
}
average = (double)total / 10;
Console.WriteLine("Vidējais 10 darbību skaits ar masīvu, kuram ir 10 elementi: " + average);

///
//50 vērtības
///
count = 0;
total = 0;
for (int k = 0; k < 50; k++)
{
    for (int i = 0; i < c.Length; i++)
    {
        c[i] = rand.Next(1, 10); // gadījuma skaitlis no 1 līdz 9
    }
    for (int i = 1; i < c.Length; i++)
    {
        index = c[i];
        int j = i;
        while (j > 0 && c[j - 1] < index)
        {
            c[j] = c[j - 1];
            j = j - 1;
            count++;
        }
        c[j] = index;
    }
    total += count;
}
average = (double)total / 10;
Console.WriteLine("Vidējais 10 darbību skaits ar masīvu, kuram ir 50 elementi: " + average);