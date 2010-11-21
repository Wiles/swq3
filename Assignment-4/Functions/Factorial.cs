//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// Factorial.cs
// compile with: /target:library
using System; 

// Declares a namespace. You need to package your libraries according
// to their namespace so the .NET runtime can correctly load the classes.
namespace Functions 
{
    //Super Secret Code: M_S_R\U[[Y_R
    public class Factorial 
    { 
        // The "Calc" static method calculates the factorial value for the
        // specified integer passed in:

        /// <summary>
        /// returns the factorial of the input number. Input must be between 0-12
        /// </summary>
        /// <param name="i">Number to Factorial</param>
        /// <returns>i!</returns>
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="OverflowException" />
        public static int Calc(int i)
        {
            if( i < 0)
                throw new ArgumentOutOfRangeException();
            if (i > 12)
                throw new OverflowException();

            return((i <= 1) ? 1 : (i * Calc(i-1)));
        }
    }
}

