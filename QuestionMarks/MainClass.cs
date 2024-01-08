using System;

class MainClass {

  public static string QuestionsMarks(string str) {
    var count = 0;
    var digits = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

    // find numeric character, find next numeric character after
    // if the int version of char at left + right = 10 and there are exactly ??? between
    // increment count

    for (int i=0; i < str.Length; i++)
    {
      var j = str.IndexOfAny(digits, i + 1);
      if (j > 1 && Char.IsDigit(str[i]) && j < str.Length && Char.IsDigit(str[j]))
      {
        var left = int.Parse(str.Substring(i, 1));
        var right = int.Parse(str.Substring(j, 1));
        if (left + right == 10)
        {
          var qc = 0;
          for (int qi=i; qi < j; qi++)
          {
            if (str[qi] == '?') {
              qc += 1;
            }
          }
          if (qc == 3)
          {
            count += 1;
          }
        }
      }
    }

    return count > 0 ? "true" : "false";
  }

  static void Main() {  
    Console.WriteLine(QuestionsMarks(Console.ReadLine()));
  } 

}