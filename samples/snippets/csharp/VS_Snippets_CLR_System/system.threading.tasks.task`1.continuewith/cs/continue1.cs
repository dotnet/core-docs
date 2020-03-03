﻿// <Snippet1>
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Timers = System.Timers;

public class Example
{
   static CancellationTokenSource ts;
   
   public static void Main(string[] args)
   {
      int upperBound = args.Length >= 1 ? Int32.Parse(args[0]) : 200;
      ts = new CancellationTokenSource();
      CancellationToken token = ts.Token;
      Timers.Timer timer = new Timers.Timer(3000);
      timer.Elapsed += TimedOutEvent;
      timer.AutoReset = false;
      timer.Enabled = true;

      var t1 = Task.Run(() => { // True = composite.
                                // False = prime.
                                bool[] values = new bool[upperBound + 1];
                                for (int ctr = 2; ctr <= (int) Math.Sqrt(upperBound); ctr++) {
                                   if (values[ctr] == false) {
                                      for (int product = ctr * ctr; product <= upperBound;
                                                                    product = product + ctr)
                                         values[product] = true;
                                   }
                                   token.ThrowIfCancellationRequested();
                                }
                                return values; }, token);

      var t2 = t1.ContinueWith( (antecedent) => { // Create a list of prime numbers.
                                                  var  primes = new List<int>();
                                                  token.ThrowIfCancellationRequested();
                                                  bool[] numbers = antecedent.Result;
                                                  string output = String.Empty;

                                                  for (int ctr = 1; ctr <= numbers.GetUpperBound(0); ctr++)
                                                     if (numbers[ctr] == false)
                                                        primes.Add(ctr);

                                                  // Create the output string.
                                                  for (int ctr = 0; ctr < primes.Count; ctr++) {
                                                     token.ThrowIfCancellationRequested();
                                                     output += primes[ctr].ToString("N0");
                                                     if (ctr < primes.Count - 1)
                                                        output += ",  ";
                                                     if ((ctr + 1) % 8 == 0)
                                                        output += Environment.NewLine;
                                                  }
                                                  //Display the result.
                                                  Console.WriteLine("Prime numbers from 1 to {0}:\n",
                                                                    upperBound);
                                                  Console.WriteLine(output);
                                                }, token);
      try {
         t2.Wait();
      }
      catch (AggregateException ae) {
         foreach (var e in ae.InnerExceptions) {
            if (e.GetType() == typeof(TaskCanceledException))
               Console.WriteLine("The operation was cancelled.");
            else
               Console.WriteLine("ELSE: {0}: {1}", e.GetType().Name, e.Message);
         }
      }
      finally {
         ts.Dispose();
      }
   }

   private static void TimedOutEvent(Object source, Timers.ElapsedEventArgs e)
   {
      ts.Cancel();
   }
}
// If cancellation is not requested, the example displays output like the following:
//       Prime numbers from 1 to 400:
//
//       1,  2,  3,  5,  7,  11,  13,  17,
//       19,  23,  29,  31,  37,  41,  43,  47,
//       53,  59,  61,  67,  71,  73,  79,  83,
//       89,  97,  101,  103,  107,  109,  113,  127,
//       131,  137,  139,  149,  151,  157,  163,  167,
//       173,  179,  181,  191,  193,  197,  199,  211,
//       223,  227,  229,  233,  239,  241,  251,  257,
//       263,  269,  271,  277,  281,  283,  293,  307,
//       311,  313,  317,  331,  337,  347,  349,  353,
//       359,  367,  373,  379,  383,  389,  397,  401
// If cancellation is requested, the example displays output like the following:
//       The operation was cancelled.
// </Snippet1>
