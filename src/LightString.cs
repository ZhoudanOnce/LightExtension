using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightExtension
{
    public static class LightString
    {
        public const char Space = ' ';

        public static bool IsEmpty(this string str)
        {
            return str.Trim().Equals(string.Empty);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static IEnumerable<string> Break(this string str, char separator = Space)
        {
            return str.Split(separator).Where(x => !x.IsNullOrWhiteSpace());
        }

        public static IEnumerable<string> Break(this string str, string separator)
        {
            return str.Split(separator).Where(x => !x.IsNullOrWhiteSpace());
        }

        public static bool Any(this string str, char find)
        {
            return str.ToCharArray().Contains(find);
        }

        public static bool Any(this string str, string find)
        {
            return str.IndexOf(find) > 0;
        }

        public static int Count(this string str, char find)
        {
            return str.Count(find.ToString());
        }

        public static int Count(this string str, string find)
        {
            return str.Length - str.Replace(find, string.Empty).Length;
        }

        public static bool IsMatch(this string str, string regex)
        {
            return Regex.IsMatch(str, regex);
        }
    }
}