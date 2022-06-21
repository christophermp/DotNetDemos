

//Dictionary<string, string> lookup = new Dictionary<string, string>();

//lookup["animal"] = "Not a human";
//lookup["fish"] = "Not a human that swims";
//lookup["human"] = "Us";

//Console.WriteLine($"The definition of fish is {lookup["fish"]}");


//Dictionary<int, string> employees = new Dictionary<int, string>();

//employees[95] = "Christopher Pettersen";
//employees[28] = "Katinka Pettersen";

//Console.WriteLine($"The employee with id number 28 is {employees[28]}");


//Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

//dayOfWeek["Wednesday"] = 4;
//dayOfWeek["Thursday"] = 5;
//dayOfWeek["Friday"] = 6;

//Console.WriteLine($"Wedensday is day number {dayOfWeek["Wednesday"]}");


Dictionary<int, string> employee = new Dictionary<int, string>();

employee[1] = "Christopher Pettersen";
employee[2] = "Daria Meldre Pettersen";
employee[3] = "Katinka Pettersen";
employee[4] = "Raptuz Pettersen";
employee[5] = "Tobias Meldre Pettersen";

do
{
    Console.Write("Please enter user ID: ");
    string userId = Console.ReadLine();

    int idToNumber = int.Parse(userId);
    if (employee != null)
    {
        Console.WriteLine(employee[idToNumber]);
    }
    else
    {
    
        Console.Write("Please enter user ID: ");
        userId = Console.ReadLine();
    }

} while (true);

