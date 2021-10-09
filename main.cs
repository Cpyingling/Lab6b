/*Author Charlie Yingling                         Date 10/7/21
*/
using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int[] num = new int[10];
    int[] EvenNum = new int[10];
    int[] OddNum = new int[10];

    //Loop 10 times:
    for (int i=0; i < num.Length; ) {
      //Get numbers as input
    Console.WriteLine("Enter a number: ");
      num[i] = Convert.ToInt32(Console.ReadLine());
      if (num[i] % 2 == 0) {
        //If number is even, store in an array called EvenNum.
	    EvenNum[i] = num[i];
	    } else {
        //If number is odd, store in an array called OddNum.
      OddNum[i] = num[i];
      }
      i++;
      if(i==10) {
        //Display EvenNum array in ascending order
      Console.WriteLine("EvenNumbers in ascending order: ");
      //Find sum of EvenNum array and display sum.
      Console.WriteLine("Sum of EvenNumbers= " + EvenNum.Sum());
      foreach (int e in EvenNum) {
        Array.Sort(EvenNum);
  Console.WriteLine(e);
}
      //Display OddNum array in descending order
      Console.WriteLine("OddNumbers in descending order: ");
      //Find sum of OddNum array and display sum.
      Console.WriteLine("Sum of OddNumbers= " + OddNum.Sum());
      foreach (int o in OddNum) {
        Array.Sort(OddNum);
        Array.Reverse(OddNum);
          Console.WriteLine(o);
    }
      }
    }
    }
}
