string[] arr = { "A", "A", "B", "C", "D", "A", "C" };
int[] arr1 = new int[arr.Length];
//int[] arr2 = new int[arr.Length];

//3
var results = from str in arr
              let c = arr.Count(m => str.Contains(m.Trim()))
              select str + c ;

foreach (string str in results) //results.Distinct() ja tikai unikālās vērtības
{

    Console.Write($"{str} ");
}
