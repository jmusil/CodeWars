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
            if (words == "")
            {
                return "";
            }

            var separatedWords = words.Split(' ').ToList();
            var kvp = new List<KeyValuePair<int,string>>();
            foreach (var word in separatedWords)
            {
                kvp.Add(new KeyValuePair<int, string>(GetNumberFromString(word), word));
            }

            var result = new StringBuilder();
            foreach (var word in kvp.OrderBy(x => x.Key))
            {
                result.Append(word.Value + " ");
            }

            return result.ToString().TrimEnd();
        }

        public static int GetNumberFromString(string input)
        {
            return Int32.Parse(input.ToCharArray().First(x => Char.IsDigit(x)).ToString());
        }
    }
}
