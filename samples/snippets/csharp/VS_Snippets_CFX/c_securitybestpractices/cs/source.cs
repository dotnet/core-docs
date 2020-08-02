﻿using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;

[assembly: SecurityPermission(
   SecurityAction.RequestMinimum, Execution = true)]
namespace Design2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void Run()
        {
            //<snippet1>
            WindowsIdentity identity = ServiceSecurityContext.Current.WindowsIdentity;
            using (identity.Impersonate())
            {
                // Run code under the caller's identity.
            }
            //</snippet1>
        }
    }
}
