using System;
using System.Text;

class MainClass {

  public static string FindIntersection(string[] strArr) {

    StringBuilder sb = new StringBuilder();
    var leftArr = strArr[0].Split(", ", StringSplitOptions.RemoveEmptyEntries);
    var rightArr = strArr[1].Split(", ", StringSplitOptions.RemoveEmptyEntries);
    var left = 0;
    var right = 0;

    while (left < leftArr.Length && right < rightArr.Length) 
    {
      if (leftArr[left] == rightArr[right])
      {
        if (sb.Length > 0)
        {
          sb.Append(",");
        }
        sb.Append(leftArr[left]);
        left += 1;
        right += 1;
      }
      else
      {
        if (Convert.ToInt32(leftArr[left]) < Convert.ToInt32(rightArr[right])) {
          left += 1;
        } else {
          right += 1;
        }
      }
    }

    return sb.Length == 0 ? "false" : sb.ToString();
  }

  static void Main(string[] args) {  

    // keep this function call here
    Console.WriteLine(FindIntersection(args));
    
  } 

}