using System.Text.RegularExpressions;

namespace OpenSocio.Common.Extensions
{
    public static class StringExtensions
    {
        /**
         * Retornar se a string não esta vazia
         */
        public static bool IsNotEmpty(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
        
        /** Retornar se a string esta vazia */
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /** Retorna se a string é vazia ou nula */
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool MatchRegex(this string input, string pattern, RegexOptions options = RegexOptions.IgnoreCase)
        {
            return Regex.IsMatch(input, pattern, options);
        }        
    }
}