using System;
using System.Text.RegularExpressions;
using System.Linq;

class MainClass {

  public static string LongestWord(string sen) {
    Regex rex = new Regex(@"[^\w\s]");
    var arr = rex.Replace(sen, "").Split(' ');

    return arr.OrderByDescending(s => s.Length).First();
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(LongestWord(Console.ReadLine()));
    
  } 

}