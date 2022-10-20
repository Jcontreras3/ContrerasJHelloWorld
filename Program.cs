//Jovann Contreras
//Date 10/17/2022
//Redid mini challenge 1 saying hello with data validation
Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{
    Console.WriteLine("Welcome to Mini Challenge 1!");
    Console.WriteLine("Enter your name to get a response!");

    bool isWord = true;
    string name = Console.ReadLine();
    while (isWord)
    {
        bool str = name.All(Char.IsLetter);
        if (!str)
        {
            Console.WriteLine("Please enter in your name no numbers");
            isWord = true;
            break;
        }
        else
        {
            Console.WriteLine($"Hello {name} how are you");
            break;
        }
    }




    Console.Write("Would you like to try again? Type in Yes to retry or No to quit ");

    string retryInput = "";

    while (retryInput != "yes" || retryInput != "no")
    {
        retryInput = Console.ReadLine().ToLower();
        if (retryInput == playAgain)
        {
            break;
        }
        else if (retryInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = retryInput;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input type in Yes or No");
            retryInput = "Invalid";
        }
    }


}

