﻿//<Snippet2>
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Example
{
   public static void Main()
   {

      int nTasks = 0;
      List<Task> tasks = new List<Task>();
      
      try {
         for (int ctr = 0; ctr < 10; ctr++)
            tasks.Add(Task.Run( () => { // Instead of doing some work, just sleep.
                                        Thread.Sleep(250);
                                        // Increment the number of tasks.
                                        Monitor.Enter(nTasks);
                                        try {
                                           nTasks += 1;
                                        }
                                        finally {
                                           Monitor.Exit(nTasks);
                                        }
                                      } ));
         Task.WaitAll(tasks.ToArray());
         Console.WriteLine("{0} tasks started and executed.", nTasks);
      }
      catch (AggregateException e) {
         String msg = String.Empty;
         foreach (var ie in e.InnerExceptions) {
            Console.WriteLine("{0}", ie.GetType().Name);
            if (! msg.Contains(ie.Message))
               msg += ie.Message + Environment.NewLine;
         }
         Console.WriteLine("\nException Message(s):");
         Console.WriteLine(msg);
      }
   }
}
// The example displays the following output:
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//    SynchronizationLockException
//
//    Exception Message(s):
//    Object synchronization method was called from an unsynchronized block of code.
// </Snippet2>
