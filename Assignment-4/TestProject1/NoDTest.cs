using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Functions;

namespace TestProject1
{
    [TestClass]
    public class NoDTest
    {
        const string digits = "0123456789";

        const string alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        const string mix = "01A2BC3DEF4GHIJ5KLMNO6PQRSTU7VWXYZab8cdefghij9klmnopqrst01u2vw2xyz3!@#$%^&*()_+=-`~ {}|[]\\:\";'<>?,./ǅǆ";

        const int mixDigitLength = 15;
        const int mixAlphaLength = 52;

        /// <summary>
        /// Check for exception for NULL input
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NodNullString()
        {
            StringBreakout.NumberOfDigits((string)null);
        }

        /// <summary>
        /// Blank string to ensure value is zero
        /// </summary>
        [TestMethod]
        public void NodBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(""), 0);
        }

        /// <summary>
        /// Single correct character extraction
        /// </summary>
        [TestMethod]
        public void NodSingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(alphas + "1"), 1);
        }

        /// <summary>
        /// Ensures that each of the 10 base 10 digits are recognized
        /// </summary>
        [TestMethod]
        public void NodEachDigits()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(digits), digits.Length);
        }

        /// <summary>
        /// Check that mix finds right number of digits
        /// If the correct number is returned than it can be assumed that no non-digit characters were counted
        /// Since we know that we do read all digits from the last test
        /// </summary>
        [TestMethod]
        public void NodMixCheck()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(mix), mixDigitLength);
        }
    }
}
