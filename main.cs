using System;
using System.Threading;

class Program {
  static int[] randomNumbers = new int[6];
  static int[] userNumbers = new int[6];
  static int max = 200;
  static int length = randomNumbers.Length;
  static bool[] correctNumbers = {
    false,
    false,
    false,
    false,
    false,
    false
  };


  public static void Main (string[] args) {

    Console.Clear();


    /*
    . generates the random integers
    . checks that there are no duplicate integers
    . takes in the user's integers
    . checks if the user's integers are the same as the generated
    . declares if the user has won any 'money'
    */

    GenerateNumbers();
    validateNumbers();
    userInput();
    Match();
    DeclareWinnings();
  }

  static void GenerateNumbers()
  {
    // loops for length or array
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      // uses Random() to set every int in array to a 
      // random value 
      Random random = new Random();
      randomNumbers[i] = random.Next(0, max);
    }
  }



  static void validateNumbers()
  {
    /* 
      This Method Validates that all
      of the numbers in randomNumbers[]
      are not duplicates
    */


    // nested for loop to comapre every number in array
    for(int i = 0; i < userNumbers.Length - 1; i++)
    {
      for(int j = 0; j < userNumbers.Length - 1; j++)
      {
        // if statement checks if the values are the same
        // only exectues if the iteration of i and j are not the same
        // if they were then that would be the same value, not a duplicate
        if((randomNumbers[i] == randomNumbers[j]) && (i != j))
        {
          // adds random object
          Random random = new Random();
          // sets the value to a random integer
          randomNumbers[i] = random.Next(0, max);
        }
      }
    }
  }






  static void userInput()
  {
    // takes in the user's input
    Console.WriteLine("Please Enter 6 Numbers From 1 to 200");

    for(int i = 0; i < userNumbers.Length; i++)
    {
      Console.Write("> ");
      try
      {
        userNumbers[i] = Convert.ToInt16(Console.ReadLine());
      }
      catch(Exception e)
      {
        Console.WriteLine("That Was Not A Valid Int.");
        Thread.Sleep(1000);
        Console.WriteLine("Type R To Retry.");
        string inp = Console.ReadLine().ToLower();
        if(inp == "r")
        {
          Console.Clear();
          userInput();
        }
        else
        {
          Console.Clear();
          Console.WriteLine(e.Message);
          Environment.Exit(0);
        }
      }
    }
  }

  static void Match()
  {
    for(int i = 0; i < userNumbers.Length; i++)
    {
      for(int j = 0; j < userNumbers.Length; j++)
      {
        if(userNumbers[i] == randomNumbers[j])
        {
          correctNumbers[i] = true;
        }
      }
    }
  }



  static void DeclareWinnings()
  {
    // creates a 2d array with [ number of correct numbers, money won ]
    int[,] winnings = {
      {0, 0},
      {1, 0},
      {2, 0},
      {3, 0},
      {4, 1000},
      {5, 10000},
      {6, 1000000}
    };
    // running Total of the amount of correct numbers
    int runningTotal = 0;
    // for loop adds 1 to runningTotal for each value correct
    for(int i = 0; i < correctNumbers.Length; i++)
    {
      if(correctNumbers[i])
        runningTotal++;
    }
    /* loops through the first coloum of the 2d array
    and check if the running total is equal to the iteration
    */
    
    for(int j = 0; j < winnings.GetLength(0); j++)
    {
      if(runningTotal == winnings[j, 0])
      {
        Console.WriteLine("You Won £" + winnings[j, 1]);
        break;
      }
    }

    Thread.Sleep(2500);
    Console.Clear();
    Console.Write("The Lucky Numbers Were: ");
    Thread.Sleep(500);

    for(int l = 0; l < randomNumbers.Length; l++)
    {
      if(l < randomNumbers.Length - 1)
      {
        Console.Write(randomNumbers[l] + ", ");
      }
      else
      {
        Console.WriteLine(randomNumbers[l]);
      }
      Thread.Sleep(500);
    }
  }



  

}
