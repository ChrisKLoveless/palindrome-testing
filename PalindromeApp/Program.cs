using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Input a Palindrome");
      string userInput = Console.ReadLine();
      if (Pal.IsPal(userInput))
      {
        Console.WriteLine("That IS a Palindrome");
      }
      else
      {
        Console.WriteLine("That is Not a Palindrome");
      }
    }
  }
}