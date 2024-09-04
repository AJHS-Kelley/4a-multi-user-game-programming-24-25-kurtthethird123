using System;

class FlowControlStructures {
  static void Main() {
  // These blocks of code are use to control how the program executes.
  // Basically, these blocks of code allow for desisions to be made.

  int age = 44;
  double cheesBurgers = 1.25D;
  string favflavor = "Butterscotch";
  bool afraidSnakes = false;

  // Can i vote?
  if (age >= 18) // (Age >= 18) is the CONDITIONAL STATEMENT
  {
    Console.WriteLine("You can vote!\n");
  }
  else if (age >= 16) // Check this NEXT if line #13 is false
  {
    Console.WriteLine("You can vote but you can register\n");
  }
  else
  {
    Console.WriteLine("you are not old enough to vote.\n");
  }

  int day = 1;
  switch(day)
  {
    case 1:
      Console.WriteLine("It's Monday.\n");
      break;
    case 2:
      Console.WriteLine("It's Tuesday.\n");
      break;
    case 3:
      Console.WriteLine("It's Wednesday.\n");
      break;
    case 4:
      Console.WriteLine("It's Thursday.\n");
      break;
    case 5:
      Console.WriteLine("It's Friday.\n");
      break; 
    case 6:
      Console.WriteLine("It's Saturday.\n");
      break;
    case 7:
      Console.WriteLine("It's Sunday, go rest.\n");
      break;
  }
  
  // REPEATING STEPS OVER, AND OVER, AND OVER AGAIN
  // LOOPS are used to repeat instructions multiple times.

  // while Loops are "musical chairs" in computer science.
  // use while loops if you DO NOT know how much loops you need.
  // the code will run as long as the condition is true.
  // while loop syntax:
  /*

  while (CONDITIONAL_EXPRESSION)
  {
    Code to loop here
  } 
  
  
    int z = 0;
  while (z <= 100) // What do i replace CONDITIONAL_EXPRESSION with?
  {
    Console.WriteLine(z);
    z++;
  }

  int y = 100;
  while (y => 0) // What do i replace CONDITIONAL_EXPRESSION with?
  {
    Console.WriteLine(y);
    y--;
  }
  /*
  you can have a single if statement by itself.
  If you have an else you MUST also have an if.
  You can have as many else if statements as needed.
  FOR NOW, USE THE else CONDITION TO PRINT ERROR MESSAGES / LOSS
  */
  
  // for loops are like playing go fish
  // you know how many cards in your hand
  // used when you know how many loops you need ahead of time

  /*
  for (statement 1; statement 2; statement 3)
  {
    Code to run each time through loop.
  }

  statement1 = code to run ONE TIME before the loop starts.
  statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop now.
  statement3 = code to run AFTER each loop.

  Each 'trip' through the loop is called an ITERATION.
  */

  // Counting to 10 with for loops.
  for (int i = 0; i <= 10; i++)
  {
    Console.WriteLine(i);
  }

 // Test

  }
}
  
