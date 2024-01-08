using System;

class MainClass {

  public static string FirstReverse(string str) {
    var result = "";
    var lastInd = str.Length - 1;
    for (int i=0; i < str.Length; i++) {
      result += str[lastInd - i];
    }

    return result;
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FirstReverse(Console.ReadLine()));
    
  } 

}