﻿// <Snippet2>
using System.IO;

class Example
{
    static void Main()
    {
        char[] buffer = new char[50];
        StreamReader? streamReader = null;
        try
        {
            streamReader = new StreamReader("file1.txt");
            int charsRead = 0;
            while (streamReader.Peek() != -1)
            {
                charsRead = streamReader.Read(buffer, 0, buffer.Length);
                //
                // Process characters read.
                //
            }
        }
        finally
        {
            // If non-null, call the object's Dispose method.
            streamReader?.Dispose();
        }
    }
}
// </Snippet2>
