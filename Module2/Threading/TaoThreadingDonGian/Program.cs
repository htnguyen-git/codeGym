﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Threading;

namespace TaoThreadingDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator ng1 = new NumberGenerator();
            NumberGenerator ng2 = new NumberGenerator();
            Thread thread1 = new Thread(ng1.Run);
            Thread thread2 = new Thread(ng2.Run);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();

        }
       
        
    }
}
