using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenges {
  public class multiplyThree {
    public static void Main(string[] args) {
        int num1, num2, num3, ans;
        Console.WriteLine("What is the first number?");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the next number?");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the third number?");
        num3 = int.Parse(Console.ReadLine());
        ans = (num1 * num2 * num3);
        Console.WriteLine("\nVoila!! "+ num1, " x " + num2, " x " + num3, " = " + ans);
    }
  }
}