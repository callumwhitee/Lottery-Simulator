using System;
using System.Threading;

class Program {

  static int[] randomNumbers = new int[6];
  static int[] userNumbers = new int[6];
  static int max = 200;
  static int length = randomNumbers.Length;


  public static void Main (string[] args) {
    GenerateNumbers();
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
      userNumbers[i] = Console.ReadLine();
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
          Console.WriteLine("yayy");
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
    Thread.Sleep();
  }
}