using Methods;

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//double result = MathShortcuts.Add(5, 3);
//Console.WriteLine($"The result is {result}");

//double[] vals = new double[] {2,5,6,21,52,98};
//MathShortcuts.AddAll(vals);

//ConsoleMessages.SayGoodbye();


(string firstName, string lastName) = ConsoleMessages.GetFullName();

Console.WriteLine($"First Name: {firstName}");
Console.WriteLine($"Last Name: {lastName}");
