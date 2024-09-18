using System;

class Template {
  
  static void Main() {
  
  string rock = "";
  string paper = "";
  string scissors = "";
  
  string CPUChoice = "";
  string numChoices = "";
  string playerChoice = "";
  
  int playerPoints = 0;
  int CPUPoints = 0;

  Console.WriteLine("Hello and welcome to the game!!!\n");
  Console.WriteLine("Please choose from the following\n");
  Console.WriteLine("Rock, Paper and Scissors\n");

  while (CPUPoints > 5 & playerPoints > 5 )
  {
    if (rock < paper)
    {
      Console.WriteLine("Paper beats Rock\n");
    }
    else if (rock > scissors)
    {
      Console.WriteLine("Rock beats Scissors");
    }
    else if (scissors < paper)
    {
      Console.WriteLine("Scissors beat Paper");
    }
    else if (playerChoice > CPUChoice)
    {
      Console.WriteLine("You Win");
    }
    else (playerChoice < CPUChoice)
    {
      Console.WriteLine("Computer Wins");
    }

  }



  }
}
  
