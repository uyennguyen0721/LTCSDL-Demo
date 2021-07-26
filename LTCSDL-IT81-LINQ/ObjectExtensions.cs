using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_IT81_LINQ
{
    static class ObjectExtensions
    {
        // This method allows any integer to reverse its digits.
        // For example, 56 would return 65.
        public static int ReverseDigits(this int i)
        {
            // Translate int into a string, and then
            // get all the characters.
            char[] digits = i.ToString().ToCharArray();
            // Now reverse items in the array.
            Array.Reverse(digits);
            // Put back into string.
            string newDigits = new string(digits);
            // Finally, return the modified string back as an int.
            return int.Parse(newDigits);
        }

    }
}
