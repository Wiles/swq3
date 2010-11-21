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
        /// Test Identifier:
        ///     NooNullString
        /// Description:
        ///     Tests for a null exception
        /// Method:
        ///     Automatic
        /// Input:
        ///     null string
        /// Expected Output:
        ///     NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NooNullString()
        {
            StringBreakout.NumberOfOthers((string)null);
        }

        /// <summary>
        /// Test Identifier:
        ///     NooBlankString
        /// Description:
        ///     Tests for correct handling of blank string
        /// Method:
        ///     Automatic
        /// Input:
        ///     Empty Sting
        /// Expected Output:
        ///     0
        /// </summary>
        [TestMethod]
        public void NooBlankString()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers(""), 0);
        }

        /// <summary>
        /// Test Identifier:
        ///     NooSingleExtraction
        /// Description:
        ///     Tests ability to find a single other in a string
        /// Method:
        ///     Automatic
        /// Input:
        ///     Alphas characters plus questionmark
        /// Expected Output:
        ///     1
        /// </summary>
        [TestMethod]
        public void NooSingleExtraction()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers( alphas + "?"), 1);
        }


        /// <summary>
        /// Test Identifier:
        ///     NooDigitatAlphas
        /// Description:
        ///     Extraction test of a highly mixed string
        /// Method:
        ///     Automatic
        /// Input:
        ///     mixed string
        /// Expected Output:
        ///     Correct number of others. Determined at run time
        /// </summary>
        [TestMethod]
        public void NooDigitAlphas()
        {
            Assert.AreEqual(StringBreakout.NumberOfOthers(mix), mix.Length - mixAlphaLength - mixDigitLength);
        }
    }
}
