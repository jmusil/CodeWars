using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Kata
    {
        public static string Order(string words)
        {
            return "";
        }

        public static int GetNumberFromString(string input)
        {
            return Int32.Parse(input.ToCharArray().First(x => Char.IsDigit(x)).ToString());
        }
    }
}
