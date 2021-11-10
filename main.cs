using System;

class Program {

  static int[] randomNumbers = new int[6];
  static int[] userNumbers = new int[6];
  static int max = 200;
  static int length = randomNumbers.Length;


  public static void Main (string[] args) {
    GenerateNumbers();
  }




  static void GenerateNumbers()
  {
    for(int i = 0; i < length; i++)
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
      
    }
  }
}