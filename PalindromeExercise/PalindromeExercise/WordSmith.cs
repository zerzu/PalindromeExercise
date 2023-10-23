using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
               reverse += word.Substring(i, 1);
            }

            return word.CompareTo(reverse) == 0;


        }

        

    }

}
