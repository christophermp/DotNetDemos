

//for (int i = 0; i < length; i++)
//{

//}

//string data = "Christopher,Daria,Katinka,Tobias";
//List<string> firstNames = data.Split('\u002C').ToList();

//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine(firstNames[i]);
//}


List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(15.89M);
charges.Add(125M);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Our total charge is {total}");