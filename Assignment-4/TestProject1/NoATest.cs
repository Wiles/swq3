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
        /// Check for exception for NULL input
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NoaNullString()
        {
            StringBreakout.NumberOfAlphas((string)null);
        }

        /// <summary>
        /// Blank string to ensure value is zero
        /// </summary>
        [TestMethod]
        public void NoaBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(""), 0);
        }

        /// <summary>
        /// Single correct character extraction
        /// </summary>
        [TestMethod]
        public void NoASingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(digits + "A"), 1);
        }

        /// <summary>
        /// Ensures all 52 A-Z,a-z are counted
        /// </summary>
        [TestMethod]
        public void NoaEachDigits()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(alphas), alphas.Length);
        }

        /// <summary>
        /// Check that mix finds right number of alphas
        /// If the correct number is returned than it can be assumed that no non-alpha characters were counted
        /// Since we know that we do read all alphas from the last test
        /// </summary>
        [TestMethod]
        public void NoaMixCheck()
        {
            Assert.AreEqual(StringBreakout.NumberOfAlphas(mix), mixAlphaLength);
        }
    }
}
