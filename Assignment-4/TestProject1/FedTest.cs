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
        /// Ensures null string give NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FedNullString()
        {
            StringBreakout.FindAndExtractDigits((string)null);
        }

        /// <summary>
        /// Ensures blank string gives FormatException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FedBlankString()
        {
            StringBreakout.FindAndExtractDigits("");
        }

        /// <summary>
        /// Above largest possible value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void FedOverFlow()
        {
            StringBreakout.FindAndExtractDigits("2147483648");
        }

        /// <summary>
        /// Largest possible value
        /// </summary>
        [TestMethod]
        public void FedUpperBound()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("2147483647"), int.MaxValue);
        }

        /// <summary>
        /// Check the smallest possible value
        /// </summary>
        [TestMethod]
        public void FedLowerBound()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("0"), 0);
        }

        /// <summary>
        /// Checks that all digits are recognized as such
        /// </summary>
        [TestMethod]
        public void FedEachDigit()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits(digits), 123456789);
        }

        /// <summary>
        /// Checks that leading zeros are ignored
        /// </summary>
        [TestMethod]
        public void FedStartingZeros()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("0000" + digits), 123456789);
        }

        /// <summary>
        /// Tests ability to extract numbers from a string and ignoring minus sign
        /// </summary>
        [TestMethod]
        public void FedExtractionTest()
        {
            Assert.AreEqual(StringBreakout.FindAndExtractDigits("-as12?>.34LKd56!@#$78EIDKA9"), 123456789);
        }
    }
}
