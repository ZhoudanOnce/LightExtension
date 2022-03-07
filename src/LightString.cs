using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace LightExtension
{
    public static class LightString
    {
        private const char Space = ' ';

        public static bool IsEmpty(this string input)
        {
            return input.Trim().Equals(string.Empty);
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool IsNullOrWhiteSpace(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static IEnumerable<string> Break(this string input, char separator = Space)
        {
            return input.Split(separator).Where(x => !x.IsNullOrWhiteSpace());
        }

        public static IEnumerable<string> Break(this string input, string separator)
        {
            return input.Split(separator).Where(x => !x.IsNullOrWhiteSpace());
        }

        public static bool Any(this string input, char find)
        {
            return input.ToCharArray().Contains(find);
        }

        public static bool Any(this string input, string find)
        {
            if (find.Length == 1)
            {
                return input.Any(find.ToCharArray().First());
            }
            return input.IndexOf(find) > 0;
        }

        public static int Count(this string input, char find)
        {
            return input.Count(find.ToString());
        }

        public static int Count(this string input, string find)
        {
            return input.Length - input.Replace(find, string.Empty).Length;
        }

        public static bool IsMatch(this string input, string regex)
        {
            return Regex.IsMatch(input, regex);
        }

        public static bool IsExistFile(this string input)
        {
            return File.Exists(input);
        }

        public static bool IsExistDirectory(this string input)
        {
            return Directory.Exists(input);
        }

        public static void DeleteFile(this string input)
        {
            File.Exists(input);
        }

        public static void DeleteDirectory(this string input)
        {
            File.Delete(input);
        }

        // 蛇形命名法
        public static string ToSnake(this string input)
        {
            return Regex.Replace(input, "(?<=.)([A-Z])", "_$0", RegexOptions.Compiled).ToLowerInvariant();
        }

        // 反序列化
        public static T Deserialize<T>(this string input)
        {
            return JsonSerializer.Deserialize<T>(input);
        }
    }
}