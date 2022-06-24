using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str) 
        {
            if (str.Length > 0)
            {
                var strTrim = str.Where(x => x != ' ').ToArray();
                for (int i = 0; i < (strTrim.Length / 2); i++)
                {
                    if (strTrim[i].ToString().ToUpper() != strTrim[strTrim.Length - 1 - i].ToString().ToUpper())
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
