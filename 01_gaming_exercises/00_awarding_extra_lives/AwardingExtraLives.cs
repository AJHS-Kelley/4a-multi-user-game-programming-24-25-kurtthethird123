using System;

class Template {
  static void Main(){

    Console.WriteLine("How many points do you have? \n");
    int score = Convert.ToInt32(Console.ReadLine());
    int lives = 3; 

    if (score > 10,000)
    {
     lives -= 1;
    }
    else if (score > 10,000)
    {
     lives += 2;
    }
    else (100,000 > 10,000)
    {
     lives += 3;
    }

    Console.Writeline("You aquired" + Lives + "lives");








  }
}