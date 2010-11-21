//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// FunctionClient.cs
// 
// 
using System; 

// The following using directive makes the types defined in the Functions
// namespace available in this compilation unit:
using Functions;

class FunctionClient 
{
    public static void Main(string[] args) 
    {
        int extractedNumberFromString;        

        Console.WriteLine("Function Client\n===============\n"); 

        if ( args.Length == 0 )
        {
            Console.WriteLine("Usage: FunctionTest <test string>... "); 
            return; 
        } 

        for ( int i = 0; i < args.Length; i++ )
        {
            // analyze the incoming "test string" to determine what types of 
            // characters are present ...
            //
            // first - how many digits are found within the string ...
            Console.WriteLine("The Digit Count for String [{0}] is [{1}]", args[i], StringBreakout.NumberOfDigits(args[i]));
            
            //
            // next  - how many alphabetic characters are found within the string ...
            Console.WriteLine("The Alpha Count for String [{0}] is [{1}]", args[i], StringBreakout.NumberOfAlphas(args[i]));
            
            //
            // lastly - determine the number of non-digit / non-alpha characters
            Console.WriteLine("The Other Count for String [{0}] is [{1}]", args[i], StringBreakout.NumberOfOthers(args[i]));

            // next function to call is to extract the number(s) from the string and use it to determine
            // its factorial !
            //
            // *************************************************************************************************
            // the code below assumes that the argv[i] string *only* contains digits.  I want you to write 
            // another class method in the StringBreakout class to detect and extract the numbers hidden in 
            // the incoming string and use that number in the factorial calculation
            //    for example, if the incoming string is Char1i3  <<< yes there is a "1" and "3" in that string
            //                 then the method you write would find the "1" and the "3" and return the value
            //                 13
            //    this new method should look like :
            //                 int FindAndExtractDigits(string theString)
            // *************************************************************************************************
            try
            {
                extractedNumberFromString = StringBreakout.FindAndExtractDigits((string)null);
                Console.WriteLine("   >>> {0}! = {1}", extractedNumberFromString, Factorial.Calc(extractedNumberFromString));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}

