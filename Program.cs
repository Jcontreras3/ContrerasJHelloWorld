// Jovann Contreras
// Date 10/17/2022
// Redid mini challenge 1 saying hello with data validation in the while loop and string.
// Trying to validate a string, got the validation for play again working


Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{
    Console.WriteLine("Welcome to Mini Challenge 1!");
    Console.WriteLine("Enter your name to get a response!");

    bool isWord = true;
   
    while (isWord)
    {
         string name = Console.ReadLine();
        
        bool str = name.All(Char.IsLetter);
        if (!str || string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Please enter in your name no numbers");
            isWord = true;
        }
        else
        {
            Console.WriteLine($"Hello {name} how are you");
            isWord = false;
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

