using System;

namespace MiniFacebook.Shared.Helper
{
    public static class StringHelper
    {
        public static string ToCamelCase(this string the_string)
        {
            if (the_string == null || the_string.Length < 2)
                return the_string;

            string[] words = the_string.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }
    }
}
