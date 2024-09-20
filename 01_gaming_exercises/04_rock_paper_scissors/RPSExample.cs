using System;

class Template {

  static void Main() {
    //PLAYER VARIABLE
    string PlayerName = "Test Player";
    int PlayerScore = 0;
    string PlayerChoice = "";

    // CPU VARIABLES
    int CPUScore = 0;
    string CPUChoice = "";

    Console.WriteLine("Welcome to the King Of Rock Paper Scissors Tournament\n");
    Console.WriteLine("Please enter your combatent name\n");
    PlayerName = Console.ReadLine();
    Console.WriteLine("${PlayerName} Is your combatent name?\n");
    String isCorrect = Console.ReadLine().ToLower();

    if (isCorrect = "yes")
    {
       Console.WriteLine($"Welcome {PlayerName}. Your challenger awaits\n");
    }
    else if (isCorrect = "no")
    {
       Console.WriteLine("Please enter your combatent name\n");
       PlayerName = Console.ReadLine();
    }
    else
    {
       Console.WriteLine("Unable to use answer please try again\n");
    }

    Console.WriteLine("""
    It is a fierce foe to fight
    it is well skilled in the battle of Rock 
    Paper
    and Scissor
    But i believe you have the power to defeat it
    =============================================
    Rules of the Tournament 
    Choose Rock, Paper or Scissors as the only skills
    Any and every other style will lead to discualification
    ============================================= """);

    while (PlayerScore < 5 && CPUChoice < 5)
    {
        // Print the scores.
        Console.WriteLine($"Your score: {PlayerScore}\n Oppenents Score: {CPUScore}")
        // Let the player select R, P, S,
        Console.WriteLine("Choose your techniuqe");
        PlayerChoice = Console.ReadLine().ToLower();
        if (PlayerChoice != "rock" && PlayerChoice != "paper" & PlayerChoice != "scissors")
        // Allow CPU to select randomly.
        Random rnd = new Random();
        int CPUrand = rnd.Next(0, 2);

        if (CPUrand == 0)
        {
            CPUChoice = "rock";
        }
        else if (CPUrand == 1)
        {
            CPUChoice = "paper";
        }
        else if (CPUrand == 2)
        {
            CPUChoice = "scissors";
        }
        else
        {
            Console.WriteLine("Opponent choice was not picked\n");
        }
        Console.WriteLine
        // Compare the two choices and determine a winner
        if (PlayerChoice == "rock" && CPUChoice == "Paper")
        {
            Console.WriteLine($"You Choose {PlayerChoice} and the your oppenents Choose {CPUChoice}.\n")
            Console.WriteLine("Your opponent wins")
            CPUScore++;
        }
        // Output the result 
        // Give the winner a point
    }


  }
}
  
