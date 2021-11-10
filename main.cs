using System;

class Program {

  static int[] randomNumbers = new int[6];
  static int max = 200;


  public static void Main (string[] args) {
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Console.WriteLine(randomNumbers[i]);
    }
  }




  static void GenerateNumbers()
  {
    for(int i = 0; i < randomNumbers.Length; i++)
    {
      Random random = new Random();
      randomNumbers[i] = random.Next(0, max);
    }
  }
}