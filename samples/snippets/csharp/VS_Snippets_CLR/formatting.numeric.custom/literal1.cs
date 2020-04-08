﻿using System;

public class Example
{
   public static void Main()
   {
      // <Snippet1>
      double n = 9.3;
      Console.WriteLine($@"{n:##.0\%}");
      Console.WriteLine($@"{n:\'##\'}");
      Console.WriteLine($@"{n:\\##\\}");
      Console.WriteLine();
      Console.WriteLine($"{n:##.0'%'}");
      Console.WriteLine($@"{n:'\'##'\'}");
      // The example displays the following output:
      //      9.3%
      //      '9'
      //      \9\
      //
      //      9.3%
      //      \9\
      // </Snippet1>
   }
}
