﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    // <ProgramLog>
    class ProgramLog
    {
        System.IO.FileStream logFile = null;
        void OpenLog(System.IO.FileInfo fileName, System.IO.FileMode mode) { }

        void WriteLog()
        {
            if (!this.logFile.CanWrite)
            {
                throw new System.InvalidOperationException("Logfile cannot be read-only");
            }
            // Else write data to the log and return.
        }
    }
    // </ProgramLog>
}
