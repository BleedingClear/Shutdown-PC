﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("shutdown -t");
        }
    }
}
