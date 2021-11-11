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
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Console.WriteLine(randomNumbers[i]);
    }
    Console.ReadKey();
    Console.Clear();
  }

  static void DeclareWinnings()
  {
    Console.Write("Your Lucky Numbers Are ");
    for(int i = 0; i < correctNumbers.Length; i++)
    {
      


      if(correctNumbers[i] == true)
      {
        Console.Write(randomNumbers[i] + ", ");
        Thread.Sleep(2000);
      }
    }
  }



 


}
