//Chris Martinez
//10/19/22
//Guess it #8 - Revampt
// GitHub Challenge
// What separates the work I done today from when I originally created this program, is the following;
// I kept the game at only 10 digits to guess, but now I'm able to break out the player from continuus tries, 
// after only 3 tries, if that is what I choose to set my parameter as. When before the player could keep on guessing until he landed on the number the randomizer had chosen.

Random random = new Random();
int numberToGuess = random.Next(10) + 1;
int userGuess = 0;
int numguesses = 0;
string gameOver = "yes";
//line 23 variable with a data type bool to 
//if numguess is not equal to 3,run all the code, else console.writeline the correct number.


bool isValidNum = false;



while (userGuess != numberToGuess)

{ Console.Write("Tell me a number between 1 and 10, enter your number! You have 3 guesses!: ");
 while (isValidNum != true)
 {
    Console.WriteLine("Please enter something that wont break");
    isValidNum = int.TryParse(Console.ReadLine(), out userGuess);



 }

     numguesses++;
     if (numguesses == 3)
     {
        Console.WriteLine("Out of Luck, try again");
        userGuess = numberToGuess;
        
        while (gameOver != "no" && gameOver != "NO")
        {
            Console.WriteLine("************Do you want to play again? yes/no************");
            gameOver = Console.ReadLine();
            Console.WriteLine("*******GAME OVER!, FOR YA! ******");
        }

     }
    else if (userGuess > numberToGuess)
    {
        Console.WriteLine("{0} is too high, guess again!", userGuess);
    }
    else if (userGuess < numberToGuess)
    {
        Console.WriteLine("{0} is too low, guess again!", userGuess);
    }
    else
    {
        Console.WriteLine("{0} Correcto Mundo! Congrats! Wanna play again?", userGuess);
        Console.WriteLine("Number of tries?: {0} YOU LOOSE!", numguesses);
        while (gameOver != "no" && gameOver != "NO")
        {
            Console.WriteLine("************Do you want to play again? yes/no************");
            gameOver = Console.ReadLine();
            Console.WriteLine("*******GAME OVER!, FOR YA! ******");
        }
    }
    isValidNum = false;

}