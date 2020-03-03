﻿// <Snippet1>
using System;
using System.Numerics;

public class Example
{
   public static void Main()
   {
      BigInteger[] numbers = { Int64.MaxValue * BigInteger.MinusOne, 
                               BigInteger.MinusOne, 
                               10359321239000, 
                               BigInteger.Pow(103988, 2),
                               BigInteger.Multiply(Int32.MaxValue, Int16.MaxValue), 
                               BigInteger.Add(BigInteger.Pow(Int64.MaxValue, 2), 
                               BigInteger.Pow(Int32.MaxValue, 2)) };
      if (numbers.Length < 2)
      { 
         Console.WriteLine("Cannot determine which is the larger of {0} numbers.",
                            numbers.Length);
         return;
      }
           
      BigInteger largest = numbers[numbers.GetLowerBound(0)];
      
      for (int ctr = numbers.GetLowerBound(0) + 1; ctr <= numbers.GetUpperBound(0); ctr++)
         largest = BigInteger.Max(largest, numbers[ctr]);

      Console.WriteLine("The values:");
      foreach (BigInteger number in numbers)
         Console.WriteLine("{0,55:N0}", number);

      Console.WriteLine("\nThe largest number of the series is:");
      Console.WriteLine("   {0:N0}", largest);
   }
}
// The example displays the following output:
//       The values:
//                                    -9,223,372,036,854,775,807
//                                                            -1
//                                            10,359,321,239,000
//                                                10,813,504,144
//                                            70,366,596,661,249
//            85,070,591,730,234,615,852,008,593,798,364,921,858
//       
//       The largest number of the series is:
//          85,070,591,730,234,615,852,008,593,798,364,921,858
// </Snippet1>