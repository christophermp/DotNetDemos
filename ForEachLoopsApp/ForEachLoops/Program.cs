

string data = "chrisotpher,Daria,Katinka,Tobias";
List<string> firstNames = data.Split('\u002C').ToList();


foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}

