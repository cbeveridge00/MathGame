// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

Console.WriteLine("Hello, Welcome to the math game! What is your name?: ");

string? name = Console.ReadLine();
var date = DateTime.UtcNow;
int score;
List<string> games = new List<string>();
Console.WriteLine($"Welcome {name}, it is {date.DayOfWeek}.\n");

while (true)
{
    Console.WriteLine("Press '1' to start a new game and '2' to view the Scoreboard");

    string? selection = Console.ReadLine();

    while (selection != "1" && selection != "2")
    {
        Console.WriteLine("Please enter '1' or '2'");
        selection = Console.ReadLine();
    }

    if (selection == "1")
    {
        newGame();
        Console.Clear();
        
    } else
    {
        foreach (string game in games)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        Console.Clear();
    }
}

void newGame()
{
    Console.WriteLine("--------------------------------------------------");

    Console.WriteLine(@"Let's start a new game, which of the following operations do you want to play?
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division.
    Q - Exit to Main Menu");
    Console.WriteLine("--------------------------------------------------");

    string? selection = Console.ReadLine();

    while (selection == "")
    {
        Console.WriteLine("Enter a Selection");
        selection = Console.ReadLine();
    }

    while (true)
    {
        switch (selection.Trim().ToLower())
        {
            case "a":

                Console.WriteLine("Addition Game Selected");
                games.Add($"{DateTime.Now} - Addition: Score={runAGame('+')}");
                return;
                
            case "s":

                Console.WriteLine("Subtraction Game Selected");
                games.Add($"{DateTime.Now} - Subtraction: Score={runAGame('-')}");
                return;
                
            case "m":

                Console.WriteLine("Multiplication Game Selected");
                games.Add($"{DateTime.Now} - Multiplication: Score={runAGame('*')}");
                return;
                
            case "d":

                Console.WriteLine("Division Game Selected");
                games.Add($"{DateTime.Now} - Division: Score={runAGame('/')}");
                return;
                

            case "q":
                Console.WriteLine("Goodbye");
                return;
            default:
                Console.WriteLine("Enter a Proper Selection");
                break;
        }
    }
}

int runAGame(char op)
{
    Console.Clear();
    Console.WriteLine("Answer the following. You get a point for each problem correct.");
    
    int score = 0;
    Random random;
    random = new Random();
    int firstNumber;
    int secondNumber;

    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Your score is {score}");


        firstNumber = random.Next(1, 25);
        secondNumber = random.Next(1, 25);

        if (op == '/' && (firstNumber % secondNumber != 0)) continue;
        

        Console.WriteLine($"{firstNumber} {op} {secondNumber}");
        var result = Console.ReadLine();

        try
        {
            if (op == '+' && int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct! Press any key to continue or q to quit the game and return to the main menu.");
                score++;
            } else if (op == '-' && int.Parse(result) == firstNumber - secondNumber) {
                Console.WriteLine("Correct! Press any key to continue or q to quit the game and return to the main menu.");
                score++;
            }
            else if (op == '*' && int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct! Press any key to continue or q to quit the game and return to the main menu.");
                score++;
            }
            else if (op == '/' && int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct! Press any key to continue or q to quit the game and return to the main menu.");
                score++;
            }
            else
            {
                Console.WriteLine("That's incorrect. Press any key to continue or q to quit the game and return to the main menu.");
                score--;
            }

            
            var nextItem = Console.ReadLine();

            if (nextItem == "q")
            {
                return score;
            }
        } catch (FormatException)
        {
            Console.WriteLine("You must enter a whole number. Try again.");
        }
    }

}

void runSub()
{
    Console.WriteLine("Answer the following. You get a point for each problem correct.");

}

void runMult()
{
    Console.WriteLine("Answer the following. You get a point for each problem correct.");

    }

void runDiv()
{
    Console.WriteLine("Answer the following. You get a point for each problem correct.");
}

