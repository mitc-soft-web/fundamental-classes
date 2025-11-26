using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamental_classes
{
    public class Palindrome
    {
        public bool isPalindrome(string word)
        {
            if (word == null) return false;
            int left = 0;
            int right = word.Length - 1;
           while(left < right)
           {
                if (word[left] != word[right])
                    return false;
                return true;
           }

           return isPalindrome(word);
        }
    }


}