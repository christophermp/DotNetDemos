

//List<string> fistNames = new List<string>();

//fistNames.Add("Christopher");
//fistNames.Add("Daria");
//fistNames.Add("Tobias");
//fistNames.Add("Katinka");

//Console.WriteLine(fistNames[fistNames.Count - 1]);

//List<int> ages = new List<int>();
//ages.Add(1);
//ages.Add(2);
//ages.Add(3);

//string data = "Corey,Smith,Jones";
//List<string> lastNames = data.Split(',').ToList();
//lastNames.Add("Franklin");

bool continueApp = true;
List<string> studentNames = new List<string>();
do
{
    Console.Write("Enter student name: ");
    string nameText = Console.ReadLine();
    if (nameText != null)
    {
        studentNames.Add(nameText);
        Console.WriteLine(studentNames.Count);

        foreach (var item in studentNames)
        {
            Console.WriteLine(item);
        }

        if (nameText.ToLower() == "exit")
        {
            continueApp = false;
            return;
        }
    }
    else
    {
        Console.WriteLine("You must enter a name!");
    }
} while (continueApp == true);