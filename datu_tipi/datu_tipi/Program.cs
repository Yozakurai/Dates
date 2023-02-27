
using System.Text;

Console.WriteLine("***UZD_1***");
        Console.Write("Char ");
        char chr = char.Parse(Console.ReadLine());
        Console.Write("int ");
        int inte = int.Parse(Console.ReadLine());
        Console.Write("bool ");
        bool boo = bool.Parse(Console.ReadLine());
        Console.Write("String ");
        string str = Console.ReadLine();
        Console.Write("Double ");
        double dbl = double.Parse(Console.ReadLine());
        Console.Write("Decimal ");
        decimal dec = decimal.Parse(Console.ReadLine());

        Console.Write($"Char {chr}; int {inte}; boolean {boo}; String {str}; Double {dbl};Decimal {dec}");
        Console.WriteLine();



        Console.WriteLine("\n***Uzd2***");
        //char; decimal; double; short; float; byte; sbyte; long; ulong; int; uint (Max/Min.Value)
        //Izvada datu tipa diapzonus no Minimālās vērtības līdz maksimālai

        Console.WriteLine("\tMin\t\t\t\tMax");
        Console.WriteLine($"char \t{(int)char.MinValue} \t\t\t\t{(int)char.MaxValue}");
        Console.WriteLine($"decimal {decimal.MinValue} \t{decimal.MaxValue}");
        Console.WriteLine($"double \t{double.MinValue} \t{double.MaxValue}");
        Console.WriteLine($"short \t{short.MinValue} \t\t\t\t{short.MaxValue}");
        Console.WriteLine($"float \t{float.MinValue} \t\t\t{float.MaxValue}");
        Console.WriteLine($"byte \t{byte.MinValue} \t\t\t\t{byte.MaxValue}");
        Console.WriteLine($"sbyte \t{sbyte.MinValue} \t\t\t\t{sbyte.MaxValue}");
        Console.WriteLine($"long \t{long.MinValue} \t\t{long.MaxValue}");
        Console.WriteLine($"ulong \t{ulong.MinValue} \t\t\t\t{ulong.MaxValue}");
        Console.WriteLine($"int \t{int.MinValue} \t\t\t{int.MaxValue}");
        Console.WriteLine($"uint\t{uint.MinValue} \t\t\t\t{uint.MaxValue}");
        Console.WriteLine();





        Console.WriteLine("***Uzd_3***");
        //byte - short; int - long; int - uint; int - byte
        //Parveido vērtības no mazāka diapzona uz lielāku
        byte bnum = 255;
        short snum = bnum;
        Console.WriteLine($"\nbyte({bnum}) - > short: {snum}");

        int inum = 2147483647;
        long bigNum = inum;
        Console.WriteLine($"\nint({inum}) - > long: {bigNum}");

        int innum = 2147483647;
        uint unum = (uint)innum;
        Console.WriteLine($"\nint({innum}) - > uint: {unum}");

        byte bbnum = 255;
        int iinum = bbnum;
        Console.WriteLine($"\nbyte({bbnum}) - > int: {iinum}");




        Console.WriteLine("\n***Uzd_4***");
        //double - int; string - double; float - long; char - int
        double x = 1234.7; //dbl vertiba
        int a = (int)x; //parveido dbl uz int
        Console.WriteLine($"\ndouble({x}) - > int: {a}");

        string strin = "2.51234";
        double doubll = double.Parse(strin);
        Console.WriteLine($"\nstring({strin}) - > double: {doubll}");

        float flo = 123.23f;
        long loun = (long)flo;
        Console.WriteLine($"\nfloat({flo}) - > long: {loun}");

        char chi = 'A';
        int inii = (int)chi;
        Console.WriteLine($"\nchar({chi}) - > int: {inii}");


        Console.WriteLine("***Uzd_5***");
        Console.Write("Ievadiet simbolus: ");
        string vards = Console.ReadLine(); //Ievadam mainīgo
        char[] o_array = vards.ToCharArray(); //pārveido string uz char masīvu
        char[] r_array = vards.ToCharArray(); //pārveido string uz char masīvu
        Array.Reverse(r_array); //apgriez masīvu
        for (int i = 0; i < r_array.Length; i++) //izvada masīvu
        {
            Console.Write(r_array[i]);
        }
        if (o_array.SequenceEqual(r_array)) //Ja orģinālais vārds ir vienāds ar apgriezto vārdu izvadīt...
        {
            Console.WriteLine("\nVārds ir simetrisks");
        }
        else //Ja nav vienādi...
            Console.WriteLine("\nVārds nav simetrisks");

