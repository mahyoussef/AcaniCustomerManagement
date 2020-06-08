﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Acani.Common
{
    public static class LogginService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
