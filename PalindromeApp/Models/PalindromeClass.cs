using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Pal
  {

    public static List<string> InputList (string input)
    {
      List<string> inputList = new List<string>{};
      foreach (char inp in input) {
        inputList.Add(inp.ToString());
      }
      return inputList;
    }

    public static bool IsPal(string input) {
      List<string> palList = InputList(input);
      List<string> rev = new List<string>(palList);
      rev.Reverse();
      return string.Join("", palList) == string.Join("", rev);
    }
    public static bool IsPal(int input) {
      string strInt = input.ToString();
      return IsPal(strInt);
    }
  }
}