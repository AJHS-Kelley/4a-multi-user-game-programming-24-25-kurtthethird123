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
    Console.WriteLine($"{PlayerName} Is your combatent name?\n");
    string isCorrect = Console.ReadLine().ToLower();

    if (isCorrect == "yes")
    {
       Console.WriteLine($"Welcome {PlayerName}. Your challenger awaits\n");
    }
    else if (isCorrect == "no")
    {
       Console.WriteLine("Please enter your combatent name\n");
       PlayerName = Console.ReadLine();
    }
    else
    {
       Console.WriteLine("Unable to use answer please.  try again\n");
    }

    //Console.WriteLine("""
     //It is a fierce foe to fight
     //it is well skilled in the battle of Rock 
     //Paper
     //and Scissor
     //But i believe you have the power to defeat it
     //=============================================
     //Rules of the Tournament 
     //Choose Rock, Paper or Scissors as the only skills
     //Any and every other style will lead to discualification
     //You need Five wins to defeat your opponent
     //============================================= """)

    while (PlayerScore < 5 && CPUScore < 5)
    {
        // Print the scores.
        Console.WriteLine($"Your score: {PlayerScore}\n Oppenents Score: {CPUScore}\n");
        Console.WriteLine(" ");
        // Let the player select R, P, S,
        Console.WriteLine("Choose Rock, Paper or Scissors");
        PlayerChoice = Console.ReadLine().ToLower();
        if (PlayerChoice != "rock" && PlayerChoice != "paper" & PlayerChoice != "scissors")
        {
          Console.WriteLine ("Choose your technuiqe\n");
          PlayerChoice = Console.ReadLine().ToLower();
        }
        // Allow CPU to select randomly.
        Random rnd = new Random();
        int CPUrand = rnd.Next(1, 3);

        if (CPUrand == 1)
        {
          CPUChoice = "rock";
        }
        else if (CPUrand == 2)
        {
          CPUChoice = "paper";
        }
        else if (CPUrand == 3)
        {
          CPUChoice = "scissors";
        }
        else
        {
          Console.WriteLine("Opponent choice has not picked\n");
        }
        Console.WriteLine("CPU Choice" + CPUChoice);
        
        // Compare the two choices and determine a winner
        if (PlayerChoice == "rock" && CPUChoice == "paper")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        CPUScore++;
        }
        else if (PlayerChoice == "rock" && CPUChoice == "scissors")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("You win!\n");
        PlayerScore++;
        }
        else if (PlayerChoice == "rock" && CPUChoice == "rock")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("It's a draw!");
        }
        else if (PlayerChoice == "paper" && CPUChoice == "paper")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("It's a draw!");
        }
        else if (PlayerChoice == "paper" && CPUChoice == "scissors")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        CPUScore++;
        }
        else if (PlayerChoice == "paper" && CPUChoice == "rock")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("You win!\n");
        PlayerScore++; 
        }
        else if (PlayerChoice == "scissors" && CPUChoice == "paper")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("You win!\n");
        PlayerScore++; 
        }
        else if (PlayerChoice == "scissors" && CPUChoice == "scissors")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("It's a draw!"); 
        }
        else if (PlayerChoice == "scissors" && CPUChoice == "rock")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        CPUScore++; 
        }
        
    }
    
    if (PlayerScore > CPUScore)
    {
      Console.WriteLine("Congradulations you are the champion of The King Of Rock Paper Scissors Tournament!!\n");
    }
    else
    {
      Console.WriteLine("Your Oppenent has won The King Of Rock Paper Scissors Tournament\n");
    }

  }
}

