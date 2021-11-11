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
    Numbers();
    TakeNumbers();
    Numbers();
    userInput();
    Match();
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

  static void TakeNumbers()
  {
    for(int j = 0; j < userNumbers.Length; j++)
      {
        for(int g = 0; g < userNumbers.Length; g++)
        {
          if(randomNumbers[j] == randomNumbers[g])
          {
            randomNumbers[g] = 0;
          }
        }
      }
  }

  static void Numbers()
  {
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Console.WriteLine(randomNumbers[i]);
    }
    Console.ReadKey();
    Console.Clear();
  }

  static void DeclareWinnings()
  {
    for(int i = 0; i < correctNumbers.Length; i++)
    {
      for(int j = 0; j < userNumbers.Length; j++)
      {
        for(int g = 0; g < userNumbers.Length; g++)
        {
          if()
        }
      }


      if(correctNumbers[i] == true)
      {
        Console.WriteLine("You Got ");
      }
    }
  }



 


}
