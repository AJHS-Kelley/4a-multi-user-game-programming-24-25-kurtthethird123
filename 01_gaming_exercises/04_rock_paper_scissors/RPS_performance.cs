using System;

class Template {

  static void Main() {
    //PLAYER VARIABLE
    int PlayerScore = 0;
    string PlayerChoice = "";
    int NumDraws = 0;

    // CPU VARIABLES
    int CPUScore = 0;
    string CPUChoice = "";

    // TESTING GAME LOOP
    int LoopCount = 0;
    int LoopReq = 0;
    Console.WriteLine("How many loops do you need?\n Please type an integer and press enter.\n")
    LoopReqs = Convert.ToInt32(Console.ReadLine());



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

        // Allow player to select randomly.
        int PlayerRand = rnd.Next(1,3);
        Console.WriteLine($"PlayerRand: {PlayerRand}\nCPURand: {CPURand}")
        
        // Compare the two choices and determine a winner
        /*
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
        Console.WriteLine("It's a draw!\n");
        }
        else if (PlayerChoice == "paper" && CPUChoice == "paper")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("It's a draw!\n");
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
        Console.WriteLine("It's a draw!\n"); 
        }
        else if (PlayerChoice == "scissors" && CPUChoice == "rock")
        {
        Console.WriteLine($"You chose {PlayerChoice} and the CPU chose {CPUChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        CPUScore++; 
        }
        */
        
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

