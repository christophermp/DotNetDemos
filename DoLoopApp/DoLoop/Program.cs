
bool exit = true;
string nameText;

do
{
    Console.Write("What is your name: ");
    nameText = Console.ReadLine();

    if (nameText.ToLower() != "christopher")
    {
        if (nameText.ToLower() == "exit")
        {
            exit = false;
            Console.WriteLine("Bye");
        }
        else if (nameText.ToLower() != "exit" )
        {
            Console.WriteLine($"Hello Student {nameText}");
        }
        
    }
    else if (nameText.ToLower() == "christopher")
    {
        Console.WriteLine($"Hello professor {nameText}");
    }

} while (exit == true);


//bool isValidAge;
//int age;
//int testNumber = 0;

//do
//{
//    Console.WriteLine(testNumber);
//    testNumber += 3;
//} while (testNumber <= 10);




//do
//{
//    Console.Write("What is you age: ");
//    string ageText = Console.ReadLine();

//    isValidAge = int.TryParse(ageText, out age);

//    if (isValidAge == false)
//    {
//        Console.WriteLine("That was an invalid age.");
//    }

//} while (isValidAge == false);

//Console.WriteLine($"Your age is {age}");


//do
//{

//} while (true);

//while (true)
//{

//}
