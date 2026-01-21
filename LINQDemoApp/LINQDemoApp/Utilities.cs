using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    public static class Utilities
    {
        public static int WordCount(this string str)
        {
            //if (string.IsNullOrWhiteSpace(str))
            //    return 0;
            var words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
