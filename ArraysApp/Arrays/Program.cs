

//string[] firstNames = new string[5];

//firstNames[0] = "Christopher";
//firstNames[1] = "Daria";
//firstNames[2] = "Katinka";
//firstNames[4] = "Tobias";

//Console.WriteLine($"the firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

//firstNames[0] = "Raptuz";

//Console.WriteLine(firstNames[0]);

string data = "Christopher,Daria,Tobias,Katinka,Raptuz";
string[] firstNames = data.Split(',');
//Console.WriteLine(firstNames[2]);

//Console.WriteLine(firstNames.Length);

//for (int i = 0; i < firstNames.Length; i++)
//{
//    Console.WriteLine(firstNames[i]);
//}

//string[] lastNames = new string[] { "Pettersen", "Meldre", "Novozhilova" };

//int[] ages = new int[] { 2, 3, 4 };

do
{
    Console.Write($"Write a number between {firstNames.Length - firstNames.Length}-{firstNames.Length-1}: ");
    string number = Console.ReadLine(); 
    int n;
    bool isNumeric = int.TryParse(number, out n);

    if (isNumeric == true)
    {
        Console.WriteLine(firstNames[n]);
    }
} while (true);