using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public static class ExtendStringClass
    {
        public static double ToDouble(this string s)
        {
            return Double.Parse(s);
        } 
    }
}
