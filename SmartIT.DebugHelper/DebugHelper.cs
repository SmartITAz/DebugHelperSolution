using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartIT.DebugHelper
{
    public static class DebugHelper
    {
        public static void CLog(string message, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0)
        {
            Console.WriteLine("{0} ({1}): {2}", Path.GetFileName(file), line, message);
        }

        public static void DLog(string message, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0)
        {
            Debug.WriteLine("{0} ({1}): {2}", Path.GetFileName(file), line, message);
        }

        public static void DDump(this object obj, string message)
        {
            DLog(message);
            Debug.WriteLine(JsonConvert.SerializeObject(obj));
        }
    }
}