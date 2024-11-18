using System;
using System.Linq;
using System.Collections;

class MoreArrays {

  static void Main() {
    string[] colors = {"Red","Orange","Yellow","Green","Blue","Purple"};
    // LOOPING THROUGH ARRAYS -- the old way
    for (int i = 0; i < colors.Length; i++)
    {
        Console.WriteLine(colors[i]);
    }

    // LOOPING THROUGH ARRAYS -- the new hotness
    foreach (string i in colors)
    {
        Console.WriteLine(i);
    }

    // LOOPING THROUGH ARRAY PRACTICE
    int[] number = {23, 61, 54, 789, -900, 2323, 646, 313, 323, 616};
    foreach (int i in number)
    {
        Console.WriteLine(i);
        if (i % 2 == 0) // MODULUS DIVIDED AND RETURNS THE REMAINDER
        {
            Console.WriteLine("This number is even");
        }
        else
        {
            Console.WriteLine("This number is odd");
        }
    }
    
    // MULTIDIMENSIONAL ARRAYS
    // this class will only use 2 Dimensional Arrays
    int[,] nums = {{4, 5, 6,}, {3, 2, 1,}};

    // ACCESSING ELEMENTS IN 2D ARRAYS
    Console.WriteLine(nums[0, 1]);
    Console.WriteLine(nums[1, 1]);

    // CHANGING ELEMENTS IN 2D ARRAYS
    nums[1, 2] = 0;
    // CHANGING ANY ELEMENT FROM THE FIRST ARRAY
    nums[0, 2] = 4;

    // LOOPING THROUGH 2D ARRAYS -- EASY MODE
    foreach (int i in nums)
    {
        Console.WriteLine(i);
    }

    // LOOPING THROUGH 2D ARRAYS -- HARD MODE
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.WriteLine(nums[i, j]);
        }
    }

  } // Do not delete
}
  
