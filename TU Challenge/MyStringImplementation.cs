using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input == "" || input.Trim() == "")
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static string MixString(string a, string b)
        {
            string mixedString = "";

            int maxLength = Math.Max(a.Length, b.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < a.Length)
                {
                    mixedString += b[i];
                }
                if (i < b.Length)
                {
                    mixedString += b[i];
                }
            }

            return mixedString;
        }

        public static string ToLowerCase(string a)
        {
            string loweredStr = "";
            for (int i = 0; i < a.Length; i++)
            {
                //go use le tolower de Char, si j'ai pas le string.tolower
                loweredStr += Char.ToLower(a[i]);
            }
            return loweredStr;
        }

        public static string BazardString(string input)
        {
            string skippedString = "";
            string save = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                skippedString += input[i];
            }
            for (int i = 1; i < input.Length; i += 2)
            { 
                save += input[i];
            }
                return skippedString +save;
        }

        public static string UnBazardString(string input)
        {
            string reversedString = "";
            string save = "";
            for (int i = input.Length - 1; i >= 0; i -= 2)
            {
                reversedString += input[i];
            }
            for (int i = input.Length - 2; i >= 0; i -= 2)
            {
                save += input[i];
            }
        
            return reversedString + save;
        
        }

        public static string ToCesarCode(string input, int offset)
        {
            {
                string encryptedString = "";
                foreach (char c in input)
                {
                    encryptedString += (char)(c + offset);
                }
                return encryptedString;
            }
        }

        public static string Voyelles(string a)
        {
            string vowels = "";
            a = ToLowerCase(a);
            foreach (char c in a)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' )
                {
                    vowels += c;
                }
            }

            return vowels;
        }

        public static string Reverse(string a)
        {
            {
                string reversed = "";
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    reversed += a[i];
                }
                return reversed;
            }
        }
    }
}
