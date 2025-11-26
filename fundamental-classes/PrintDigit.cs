using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamental_classes
{
    public class PrintDigit
    {
        public string PrintLastDigitInWords(int digits)
        {
            string num = digits.ToString();
            int length = num.Length;
            int temp = 0;

            for (int i  = 0; i < length - 1; i++)
            {
                digits /= 10;
            }

            switch (digits)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "Invalid digit";

            }
            
        }
    }
}
