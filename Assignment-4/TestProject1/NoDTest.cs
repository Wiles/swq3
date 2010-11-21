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
        /// Test Identifier:
        ///     NodNullString
        /// Description:
        ///     Checks for correct handling of a null input string
        /// Method:
        ///     Automatic
        /// Input:
        ///     null
        /// Expected Output:
        ///     NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NodNullString()
        {
            StringBreakout.NumberOfDigits((string)null);
        }

        /// <summary>
        /// Test Identifier:
        ///     NodBlankString
        /// Description:
        ///     Correct handling of blank string
        /// Method:
        ///     Automatic
        /// Input:
        ///     ""
        /// Expected Output:
        ///     0
        /// </summary>
        [TestMethod]
        public void NodBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(""), 0);
        }

        /// <summary>
        /// Test Identifier:
        ///     NodSingleExtraction
        /// Description:
        ///     Tests correct couting of a single correct character
        /// Method:
        ///     Automatic
        /// Input:
        ///     alphas plus a 1
        /// Expected Output:
        ///     1
        /// </summary>
        [TestMethod]
        public void NodSingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(alphas + "1"), 1);
        }

        /// <summary>
        /// Test Identifier:
        ///     NodEachDigits
        /// Description:
        ///     Checks that all 10 different digits are counted
        /// Method:
        ///     Automatic
        /// Input:
        ///     0-9
        /// Expected Output:
        ///     10
        /// </summary>
        [TestMethod]
        public void NodEachDigits()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(digits), digits.Length);
        }

        /// <summary>
        /// Test Identifier:
        ///     
        /// Description:
        ///     Normal test for counting Digits in large random string
        /// Method:
        ///     Automatic
        /// Input:
        ///     mix
        /// Expected Output:
        ///     mixDigitLength
        /// </summary>
        [TestMethod]
        public void NodMixCheck()
        {
            Assert.AreEqual(StringBreakout.NumberOfDigits(mix), mixDigitLength);
        }
    }
}
