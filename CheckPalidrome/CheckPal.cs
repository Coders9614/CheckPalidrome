using System;

public class CheckPal
{
    // //Function CheckPalindrome(x: Integer) -> Boolean
    // Step 1: Handle negative numbers
    
    public bool CheckPalindrome(int x)
    {
        if (x < 0)  
            return false; 


        int number = x;
        int reverse = 0;

        while (x != 0)
        {
            int digit = x % 10;//Get the last digit
            reverse = reverse % 10 + digit;//append the digit reversd number
               // Remove the last digit from x
            x /=  10;
        }
        return number == reverse;
    }
}