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
    GenerateNumbers();
    validateNumbers();
    userInput();
    Match();
    DeclareWinnings();
  }




  static void GenerateNumbers()
  {
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Random random = new Random();
      randomNumbers[i] = random.Next(0, max);
    }
  }



  static void userInput()
  {
    Console.WriteLine("Please Enter 6 Numbers From 1 to 200");
    for(int i = 0; i < userNumbers.Length; i++)
    {
      Console.Write("> ");
      userNumbers[i] = Convert.ToInt16(Console.ReadLine());
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

  

  static void Numbers()
  {

    // debug perposses


    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Console.WriteLine(randomNumbers[i]);
    }
    Console.ReadKey();
    Console.Clear();
  }

  static void DeclareWinnings()
  {
    int[,] winnings = {
      {0, 0},
      {1, 0},
      {2, 0},
      {3, 0},
      {4, 1000},
      {5, 10000},
      {6, 1000000}
    };

    int runningTotal = 0;
    for(int i = 0; i < correctNumbers.Length; i++)
    {
      if(correctNumbers[i])
        runningTotal++;
    }
    for(int j = 0; j < winnings.GetLength(0); j++)
    {
      if(runningTotal == winnings[j, 0])
      {
        Console.WriteLine("You Won £" + winnings[j, 1]);
        break;
      }
    }
  }

  static void validateNumbers()
  {
    for(int i = 0; i < userNumbers.Length - 1; i++)
    {
      for(int j = 0; j < userNumbers.Length - 1; j++)
      {
        if((randomNumbers[i] == randomNumbers[j]) && (i != j))
        {
          Random random = new Random();
          randomNumbers[i] = random.Next(0, max);
        }
      }
    }
  }

}
