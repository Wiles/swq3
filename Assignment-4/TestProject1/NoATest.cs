using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Functions;

namespace TestProject1
{
    [TestClass]
    public class NoATest
    {
        const string digits = "0123456789";

        const string alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        const string mix = "01A2BC3DEF4GHIJ5KLMNO6PQRSTU7VWXYZab8cdefghij9klmnopqrst01u2vw2xyz3!@#$%^&*()_+=-`~ {}|[]\\:\";'<>?,./ǅǆ";

        const int mixDigitLength = 15;
        const int mixAlphaLength = 52;

        /// <summary>
        /// Test Identifier:
        ///     NoaNullString
        /// Description:
        ///     Tests correct Handling of null input string
        /// Method:
        ///     Automatic
        /// Input:
        ///     null
        /// Expected Output:
        ///     NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NoaNullString()
        {
            StringBreakout.NumberOfAlphas((string)null);
        }

        /// <summary>
        /// Test Identifier:
        ///     NoaBlankString
        /// Description:
        ///     Correct handling of an empty string
        /// Method:
        ///     Automatic
        /// Input:
        ///     ""
        /// Expected Output:
        ///     0
        /// </summary>
        [TestMethod]
        public void NoaBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(""), 0);
        }

        /// <summary>
        /// Test Identifier:
        ///     NoaSingleExtraction
        /// Description:
        ///     Lower boundary of finding one correct character
        /// Method:
        ///     Automatic
        /// Input:
        ///     0-9A
        /// Expected Output:
        ///     1
        /// </summary>
        [TestMethod]
        public void NoASingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(digits + "A"), 1);
        }

        /// <summary>
        /// Test Identifier:
        ///     NoaEachAlphas
        /// Description:
        ///     Ensures each of the 52 valid characters get counted A-Za-z
        /// Method:
        ///     Automatic
        /// Input:
        ///     A-Za-z
        /// Expected Output:
        ///     52
        /// </summary>
        [TestMethod]
        public void NoaEachAlphas()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(alphas), alphas.Length);
        }

        /// <summary>
        /// Test Identifier:
        ///     NoaMixCheck
        /// Description:
        ///     Normal use highly mixed string
        /// Method:
        ///     Automatic
        /// Input:
        ///     mix
        /// Expected Output:
        ///     pre calculated number of alphas in mix
        /// </summary>
        [TestMethod]
        public void NoaMixCheck()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(mix), mixAlphaLength);
        }
    }
}
