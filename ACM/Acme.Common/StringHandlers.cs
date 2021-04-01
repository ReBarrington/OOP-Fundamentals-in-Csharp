using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                for(var i = 0; i < source.Length; i ++)
                {
                    if (char.IsUpper(source[i]) && i > 0)
                    {
                        result += " ";
                    }
                    result += source[i];
                }
            }
            return result;
        }
    }
}
