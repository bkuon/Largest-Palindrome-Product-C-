using System;

namespace Largest_Palindrome_Product
{
    class Program
    {
        static int reverseDigits(int num)
        {
            int rev_num = 0;
            while(num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;
        }
        static void Main(string[] args)
        {
            int result = 0;
            int palindrome = 0;
            for( int i = 999; i > 0; i--)
            {
                for ( int y = 999; y > 0; y--)
                {
                    result = i * y;
                    if ( result == reverseDigits(result))
                    {
                        if(result > palindrome){
                            palindrome = result; 
                        }
                    }
                }
            }

            Console.WriteLine(palindrome);
        }

    }
}

//Solution Found on 
//https://stackoverflow.com/questions/53415792/find-the-largest-palindrome-made-from-the-product-of-two-3-digit-numbers-c-sharp