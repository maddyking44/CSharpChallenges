using System;
using System.Collections.Generic;
using System.IO;

namespace Challenges {
  public class multiplyThree {
    public static void Main(string[] args) {
        string str;
        List<int> myList = new List<int>();
        Console.WriteLine("What is the string?");
        str = (Console.ReadLine());
        int leng = str.Length;
        char firstChar = str[0];
        string firstLet = firstChar.ToString();
        char lastChar = str[leng-1];
        string lastLet = lastChar.ToString();
        string newStr = str.Insert(0, lastLet);
        string secStr = newStr.Insert(leng+1, firstLet);
        Console.WriteLine(leng);
        Console.WriteLine(secStr);
        }
      }
    }