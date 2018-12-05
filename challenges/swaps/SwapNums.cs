using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoloLearn {
  public class Program {
    public static void Main(string[] args) {
        int num1, num2, num3;
        Console.WriteLine("What is the first number?");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the next number?");
        num2 = int.Parse(Console.ReadLine());
        num3 = num1;
        num1 = num2;
        num2 = num3;
        Console.WriteLine("\nVoila!! Look at your numbers now!");
        Console.WriteLine("\nFirst Number: " + num1);
        Console.WriteLine("\nSecond Number: " + num2);
    }
  }
}