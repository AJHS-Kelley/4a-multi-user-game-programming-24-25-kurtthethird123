using System;

class GuessNumber {
  static void Main(){
    int numGuess = 0;
    int maxGuess = 10;
    int guess; 

    // Generate the secret number here.
    Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random()
    int secretNumber = rnd.Next(100); // Generate from 0 to 99
    //int secretNumber = rnd.Next(25, 1000); // Generate 0 to 999
    //Console.WriteLine(secretNumber);
    // While loop
    
    while (numGuess < maxGuess)
    {
       //Allow user to guess number
       //Console.WriteLine("Your secret number is" + secretNumber);
       Console.WriteLine("Please guess an integer between 0 and 99\n");
       guess = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Guess");
       numGuess++;
       // Compare guess to random number
       if (guess < secretNumber)
       {
         Console.WriteLine("Your guess is too low\n");
       }
       else if (guess > secretNumber)
       {
         Console.WriteLine("Your guess is too high\n");
       }
       else
       {
         Console.WriteLine("you guessed correctly\n");
         break; // Keyword to immediately exit a loop
       }

       if (numGuess >= maxGuess)
       {
         Console.WriteLine("You have lost the Game.\n");
       }
    }

      // Allow the user to guess the number.
      // Compare the guess to the secret number.
      // If match, print win, if > or <, give a hint
      // +1 to numGuess
      // Check if numGuess > maxGusses.
      // If true, print a "lose game" message, if false guess again

  }
}
  
