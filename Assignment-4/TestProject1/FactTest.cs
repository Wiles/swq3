using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Functions;

namespace TestProject1
{
    [TestClass]
    public class FactTest
    {
        int[] correctFacts = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600 };

        /// <summary>
        /// Check for range error for negative number
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FactorialNegative()
        {
            Factorial.Calc(-1);
        }

        /// <summary>
        /// Check for overflow expection for i! > int32.max
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void FactorialOverFlow()
        {
            Factorial.Calc(correctFacts.Length);
        }

        //
        // Test Identifier: FactorialGoodInput
        // Description: Tests all good input for factorial
        // Input Data: 0-12
        // Expected Output: see correctFacts array
        // 
        [TestMethod]
        public void FactorialGoodInput()
        {
            for (int i = 0; i < correctFacts.Length; ++i)
            {
                Assert.AreEqual(Factorial.Calc(i), correctFacts[i]);
            }
        }
    }
}
