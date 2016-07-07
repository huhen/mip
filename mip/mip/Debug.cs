using System;

namespace mip.Diagnostics
{
    internal class Debug
    {
        internal static void WriteLine(string text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }
    }
}
