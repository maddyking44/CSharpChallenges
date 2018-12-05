using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges {
  public class multiplyThree {
    public static void Main(string[] args) {
        Console.WriteLine("Write something?");
        string str = (Console.ReadLine());
        int leng = str.Length;
        char firstChar = str[0];
          string firstLet = firstChar.ToString();
        char lastChar = str[leng-1];
          string lastLet = lastChar.ToString();
        string newStr = str.Insert(0, lastLet);
        string secStr = newStr.Insert(leng+1, firstLet);
        string lessStr = secStr.Remove(1, 1);
        string shortStr = lessStr.Remove(leng-1, 1);
        Console.WriteLine(shortStr);
        }
      }
    }