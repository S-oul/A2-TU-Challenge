﻿using System;
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
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            throw new NotImplementedException();
        }

        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
