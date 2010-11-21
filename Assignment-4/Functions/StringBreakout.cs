//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// StringBreakout.cs
// compile with: /target:library
using System;
using System.Text;

// Declare the same namespace as the one in Factorial.cs. This simply 
// allows types to be added to the same namespace.
namespace Functions 
{

    public enum errors
    {
        OVERFLOW = -3,
        NULL_ERROR,
        FORMAT,
    }

    public class StringBreakout
    {

        // The NumberOfDigits static method calculates the number of
        // digit characters in the passed string:

        /// <summary>
        /// Calculates the number of digits in a string
        /// </summary>
        /// <param name="theString">String to check</param>
        /// <returns>Number of digits in the string</returns>
        /// <exception cref="NullReferenceException" /> 
        public static int NumberOfDigits(string theString) 
        {
            
            int count = 0; 
            for ( int i = 0; i < theString.Length; i++ ) 
            {
                //Number of Digits if in because it only checks for decimal digits
                if ( Char.IsDigit(theString, i) ) 
                {
                    count++;
                }
            }
            // let's not hold onto this count as it has no meaning to this class

            return count;
        }

        // The NumberOfAlphas static method calculates the number of
        // alphabetic characters in the passed string:

        /// <summary>
        /// Calculates number of Alpha(A-Z,a-z) characters in a string
        /// </summary>
        /// <param name="theString">String to test</param>
        /// <returns>Number of Alpha chars</returns>
        /// <exception cref="NullReferenceException" /> 
        public static int NumberOfAlphas(string theString)
        {
            int count = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                //IsLetter also includes TitleCaseLetter, ModifierLetter and OtherLetter which we do not want
                //Uppercase and Lower Case also contain non-latin letters
                if (theString[i] >= 'A' && theString[i] <= 'Z' || theString[i] >= 'a' && theString[i] <= 'z')
                {
                    count++;
                }
            }
            // let's not hold onto this count  

            return count;
        }

        // The NumberOfOthers static method calculates the number of
        // non-digit / non-alphabetic characters in the passed string:
        //
        // *********************************************************************************
        //  QUESTION : is there a better and more reliable way to determine
        //             the number of "others" ?  Does it matter which order
        //             the NumberOfDigits(), NumberOfAlphas() and NumberOfOthers()
        //             methods are called ?
        //  ANSWER   : How this is writen right now is very dangerous. It requires 
        //             NumberOfAlphas() and NumbersOfDigits() to be called for for the
        //             string that is being tested. Instead just take the length and subtract
        //              The return values from calls to the other two functions.
        //
        // *********************************************************************************

        /// <summary>
        /// Calculates number of other( non digit or alpha ) characters in a string
        /// </summary>
        /// <param name="theString">String to test</param>
        /// <returns>Number of other chars</returns>
        /// <exception cref="OverFlowException" />
        /// <exception cref="NullReferenceException" />
        public static int NumberOfOthers(string theString)
        {
            return theString.Length - NumberOfDigits( theString ) - NumberOfAlphas( theString );
        }

        /// <summary>
        /// Takes in a string and attempts to create an integer based off all the digits in the string
        /// </summary>
        /// <param name="theString">Input string that digits will be extracted from</param>
        /// <returns>Integer created by concatonating all the numbers in the given string together</returns>
        /// <exception cref="System.NullReferenceException" />
        /// <exception cref="System.FormatException" />
        /// <exception cref="System.OverflowException" />
        public static int FindAndExtractDigits(string theString)
        {
            string digits = "";

            int returnNum = 0;

            for (int i = 0; i < theString.Length; ++i)
            {
                if (Char.IsDigit(theString[i]))
                    digits += theString[i];
            }
            returnNum = Int32.Parse(digits);

            return returnNum;
        }
    }
}

