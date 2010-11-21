using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Functions;

namespace TestProject1
{
    [TestClass]
    public class FedTest
    {
        const string digits = "0123456789";

        const int mixDigitLength = 15;
        const int mixAlphaLength = 52;

        /// <summary>
        /// Test Identifier:
        ///     FedNullString
        /// Description:
        ///     Tests for correct handling of null input string
        /// Method:
        ///     Automatic
        /// Input:
        ///     null
        /// Expected Output:
        ///     NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FedNullString()
        {
            StringBreakout.FindAndExtractDigits((string)null);
        }

        /// <summary>
        /// Test Identifier:
        ///     FedBlankString
        /// Description:
        ///     Correct Handling of blank String
        /// Method:
        ///     Automatic
        /// Input:
        ///     ""
        /// Expected Output:
        ///     FormatException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FedBlankString()
        {
            StringBreakout.FindAndExtractDigits("");
        }

        /// <summary>
        /// Test Identifier:
        ///     FedEachDigit
        /// Description:
        ///     Tests that all 10 different digits can be extracted
        /// Method:
        ///     Automatic
        /// Input:
        ///     "0123456789"
        /// Expected Output:
        ///     123456789
        /// </summary>
        [TestMethod]
        public void FedEachDigit()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits(digits), 123456789);
        }

        /// <summary>
        /// Test Identifier:
        ///     FedOverflow
        /// Description:
        ///     A number larger then the output can handl
        /// Method:
        ///     Automatic
        /// Input:
        ///     "2147483648"
        /// Expected Output:
        ///     OverflowException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void FedOverFlow()
        {
            StringBreakout.FindAndExtractDigits("2147483648");
        }

        /// <summary>
        /// Test Identifier:
        ///     FedUpperBound
        /// Description:
        ///     Largest accepted value
        /// Method:
        ///     Automatic
        /// Input:
        ///     "2147483647"
        /// Expected Output:
        ///     2147483647
        /// </summary>
        [TestMethod]
        public void FedUpperBound()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits(int.MaxValue.ToString()), int.MaxValue);
        }

        /// <summary>
        /// Test Identifier:
        ///     FedLowerBount
        /// Description:
        ///     Smallest possible value
        /// Method:
        ///     Automatic
        /// Input:
        ///     "0"
        /// Expected Output:
        ///     0
        /// </summary>
        [TestMethod]
        public void FedLowerBound()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("0"), 0);
        }



        /// <summary>
        /// Test Identifier:
        ///     FedLeadingZeros
        /// Description:
        ///     Tests that a large number of leading zeros ase still ignored
        /// Method:
        ///     Automatic
        /// Input:
        ///     Bunch of 0 followed by 123456789
        /// Expected Output:
        ///     123456789
        /// </summary>
        [TestMethod]
        public void FedLeadingZeros()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("00000000000000000000000" + digits), 123456789);
        }

        /// <summary>
        /// Test Identifier:
        ///     FedExtractionTest
        /// Description:
        ///     Normal usage taking numbers correctly out of mixed string also ensures that minus signs are ignored
        /// Method:
        ///     Automatic
        /// Input:
        ///     -as12?>.34LKd56!@#$78EIDKA9
        /// Expected Output:
        ///     123456789
        /// </summary>
        [TestMethod]
        public void FedExtractionTest()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("-as12?>.34LKd56!@#$78EIDKA9"), 123456789);
        }
    }
}
