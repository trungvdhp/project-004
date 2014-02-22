using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public static class IString
    {
        public static string GetLastString(this string path)
        {
            return path.Split('.').Last();
        }
    }
}
