using System;

class MainClass {

  public static string CodelandUsernameValidation(string str) {
    if (str == null || str.Length < 4 || str.Length > 25)
    {
      return "false";
    }

    if (!Char.IsLetter(str[0])) 
    {
      return "false";
    }
    if (str[str.Length - 1] == '_')
    {
      return "false";
    }
    
    for (int i=0; i < str.Length; i++)
    {
      if (!(Char.IsLetterOrDigit(str[i]) || str[i] == '_'))
      {
        return "false";
      }
    }
    
    return "true";
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    
  } 

}