//Jovann Contreras
//Date 10/17/2022
//Redid mini challenge 1 saying hello with data validation
Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{
    Console.WriteLine("Welcome to Mini Challenge 1!");
    Console.WriteLine("Enter your name to get a response!");
    string name = Console.ReadLine();
    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("You didn't Enter anything please type in a name");
        name = Console.ReadLine();
    }
    Console.WriteLine($"Hello {name} how are you");

    Console.Write("Would you like to try again? Type in Yes to retry or No to quit ");
    playAgain = Console.ReadLine().ToLower();
    if (playAgain == "yes")
    {
        continue;
    }
    else if (playAgain == "no")
    {
        Console.WriteLine("Thanks for playing ");
        
    }
    else if (playAgain != "yes" || playAgain != "no")
    {
        Console.WriteLine("not a valid pick please enter in Yes or No");
        playAgain = Console.ReadLine().ToLower();
    }


}

