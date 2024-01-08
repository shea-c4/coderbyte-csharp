using System;
using System.Collections.Generic;

class MainClass {

  public static string BracketMatcher(string str) {
    var stack = new Stack<string>();
    var isValid = true;

    foreach (var c in str)
    {
      if (c == '(') {
        stack.Push("(");        
      }
      else if (c == ')') {
        if (stack.Count == 0) {
          isValid = false;
          break;
        }
        stack.Pop();
      }
    }

    return isValid && stack.Count == 0 ? "1" : "0";
  }

  public static void Main() {  

    // keep this function call here
    Console.WriteLine(BracketMatcher(Console.ReadLine()));
    
  }
}