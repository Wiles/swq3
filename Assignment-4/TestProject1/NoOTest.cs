using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Functions;

namespace TestProject1
{
    [TestClass]
    public class NoOTest
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
        public void NooNullString()
        {
            StringBreakout.NumberOfOthers((string)null);
        }

        /// <summary>
        /// Blank string to ensure value is zero
        /// </summary>
        [TestMethod]
        public void NooBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers(""), 0);
        }

        /// <summary>
        /// Single correct character extraction
        /// </summary>
        [TestMethod]
        public void NooSingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers( alphas + "?"), 1);
        }


        /// <summary>
        /// Ensures all alphas and digits are ignored
        /// </summary>
        [TestMethod]
        public void NooDigitAlphas()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers(mix), mix.Length - mixAlphaLength - mixDigitLength);
        }
    }
}
