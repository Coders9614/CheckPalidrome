using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;





    public class PalindromeChecker
    {
        public bool CheckPalindrome(int x)
        {
            // Negative numbers are not palindromes
            if (x < 0)
                return false;

            // Store the original number
            int original = x;
            int reversed = 0;

            // Reverse the integer
            while (x != 0)
            {
                int digit = x % 10; // Get the last digit
                reversed = reversed * 10 + digit; // Append the digit to the reversed number
                x /= 10; // Remove the last digit from x
            }

            // Check if the reversed number is the same as the original
            return original == reversed;
           
        }

        public static void Main(string[] args)
        {
            PalindromeChecker checker = new PalindromeChecker();

            // Example 1
            int x1 = 121;
            Console.WriteLine(checker.CheckPalindrome(x1)); // Output: true

            // Example 2
            int x2 = -121;
            Console.WriteLine(checker.CheckPalindrome(x2)); // Output: false

        }
    }





