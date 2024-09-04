// Data Types And Operators, Tennell Curtis III, v0.0
using System;

class DataTypesOperators {
  0 references;
  // Just a comment 
  static void Main() {
    /*
    this is sill a comment 
    */

    //DATA TYPES
    //C# is STATICALLY TYPED -- once a variable has a datat type, it cannot change 
    
    //Float - float -- decimal numbersm, +/- including 0,0

    //Double - double -- decimals numbers, +/-, including 0.0 <-- MOST COMMOMLY USED DECIMAL

    //Intergers -- int -- whole numbers, +/-, including 0

    //VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

    //DECLARING (CREATING VARIABLES)
    //Method #1 -- Declared But Not Assigned
    //dataType variableName

    int myInteger;
    double myDouble;

    //Method #2 -- Declare AND Assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    // Strings -- Collections of letters, number, special characters
    string myString = "Ayecorumba";

    //Boolean -- bool - True or False values
    bool myBool = true;
    bool fireReistance = false;
    bool hasPurpleKey = true;

    // Character -- char -- a single character.
    char myChar = 'A';

    //ASSINGING VALUES AFTER DECARATION

    myInteger = 5;
    myDouble = -1.0D;

    // PRINTING VARIABLES TO THE CONSOLES TERMENIALS
    // Console.WriteLine(myInteger); 
    // Console.WriteLine(myDouble);

    // Console.WriteLine(myInteger - 25);
    // Console.WriteLine(myDouble + 2.5D);

    // Console.WriteLine(myInteger); 
    // Console.WriteLine(myDouble);

    // OPERATORS -- ARITHMETIC

    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;

    // ADDITION
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;
    double myNewNumber = myInteger + myDouble;

    // SUBTRACTION
    myNewNumber = myDouble - myInteger;

    // DIVISION
    myNewNumber = myDouble / myInteger;

    // MULTIPLICATION
    myNewNumber = myDouble * myInteger;

    // MODULUS -- Divides, then returns the REMAINDER
    // Most community used to determine EVEN or ODD
    myNewNumber = myDouble % 2;

    int students = 6;
    int numSlices = 35;
    int LeftOvers;

    LeftOvers = numSlices % students;

    //Increment / Decrement -- Most frequently used in LOOPS
    int x = 0;
    x++; // What is x equal to now?
    // Increment ++ adds I do the current value and puts the new value into the bucket
    x--;
    // Decrements -- subtracts 1 from the current value and puts the new value into the buckets

    // Special Assignments Operators
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    // TAKE CURRENT VALUE, PERFORM THE CALCULATION, PUT NEW VALUE INTO BUCKET

    // COMPARISON OPERATORS
    // EVALUATE THE EXPRESSION, RETURN true or false
    int y = 5;
    int z = 3; 

    // IS-EQUAL == is the value on the left equal to the right?
    // Console.WriteLine(y == z);

    // // NOT-EQUAL-TO != is the value on the left not equal to the right?
    // Console.WriteLine(y != z);

    // // GREATER THAN >
    // Console.WriteLine(y > z);

    // // GREATER THAN OR-EQUAL-TO
    // Console.WriteLine(y >= z);

    // // LESS THAN
    // Console.WriteLine(y < z);

    // // LESS THAN OR-EQUAL-TO
    // Console.WriteLine(y <= z);

    // LOGICAL OPERATORS
    int b = 1;
    double c = 2.0D;
    string favColor = "Blue";
    // LOGICAL AND && -- all statements must be True
    // Console.WriteLine(b > 1 && c != 5.0D); // false because b is not > 1
    // Console.WriteLine(b == 1 && c < 10.0D); // both are true, whole expression is true 
    // // If one expression most likely to be False, check for it FIRST!
    // Console.WriteLine(hasPurpleKey == true && playerlevel > 5);

    // // Logical OR || -- ONE statement must be True
    // Console.WriteLine(b > 1 || c != 5.0D); // true because c is not equal to 5.0
    // console.WriteLine(b == 2 || c > 10.0D); // false because both expressions are false 
    // // Check for the statement most likely to be true first!
    // Console.WriteLine(hasBluekey == true && playerLevel > 3);

    // LOGICAL NOT ! -- Returns the opposite value of the expression.
    Console.WriteLine(b > -1); //True
    Console.WriteLine(!(b > -1)); //False

    // READING USER INPUT FROM THE CONSOLE / TERMINAL
    Console.WriteLine("What is your player name? Type it and press ENTER. \n");

    // CREATE A VARIABLE TO SPACE THE DATA.
    string playerName = Console.ReadLine();
    // Console.Readline() ONLY RETURNS string data types
    Console.WriteLine("What is your age? Type it and press ENTER. \n")
    string age = console.Readline();
    Console.WriteLine(age + age);
    // PRINT THE VARIABLE TO THE SCREEN
    Console.WriteLine("Your player name is" + playerName);

    // Adding strings data types together is called CONCATENATION

    // PRINT THE VARIABLE ON SCREEN 
    // Console.Writeline("Your player name is" + playerName);

    // INPUTTING NUMBERS FROM THE CONSOLE.

    Console.WriteLine("how many chicken nuggets can you eat in 5 minutes.");
    int numNuggies = Convert.toInt32(Console.Readline());
    Console.WriteLine(numNuggies + numNuggies);


  }
}
