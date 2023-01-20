
//variables
int[] array = new int[] { 1, 1, 1, 2, 2, 1, 1, 2, 3, 3, 3 };
int[] arraysorted = new int[array.Length];
int count = 0;
int monday, tuesday, wednesday, thursday, friday, sunday, saturday;
monday = tuesday = wednesday = thursday = friday = sunday = saturday = 0;
//sort array
Console.WriteLine("Sorted array");
Array.Sort(array);
foreach (int pluss in array)
    {
        count++;
        switch (pluss)
        {
        case 1:
            Console.Write("Monday");
            monday++;
            break;
        case 2:
            Console.Write("Tuesday");
            tuesday++;
            break;
        case 3:
            Console.Write("Wednesday");
            thursday++;
            break;
        case 4:
            Console.Write("Thursday");
            wednesday++;
            break;
        case 5:
            Console.Write("Friday");
            friday++;
            break;
        case 6:
            Console.Write("Saturday");
            sunday++;
            break;
        case 7:
             Console.Write("Sunday");
             saturday++;
             break;
        }
        if (count < array.Length)
        {
        Console.Write(";");
         }else
         {
        Console.Write(".");
         }     
                
            
        }

        //count
        Console.WriteLine("\n\nMonday:" + monday + " Tuesday:" + tuesday + " Wednesday:" + wednesday + " Thursday:" + thursday + " Friday:" + friday + " Sunday:" + sunday + " Saturday:" + saturday + "");