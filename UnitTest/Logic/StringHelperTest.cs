using Logic;
using Logic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Logic {

    /// <summary>
    /// The StringHelperTest contains methods to test the StringHelper class
    /// </summary>
    [TestClass]
    public class StringHelperTest {

        /// <summary>
        /// Test initialize
        /// </summary>
        [TestInitialize]
        public void TestInitialize() {

        }

        /// <summary>
        /// Test cleanup
        /// </summary>
        [TestCleanup]
        public void TestCleanup() {

        }

        /// <summary>
        /// Test the IsPalindrome method
        /// </summary>
        [TestMethod]
        public void TestIsPalindrome() {
            Assert.AreEqual(true, StringHelper.IsPalindrome("ibofobi"));
        }

        /// <summary>
        /// Test the IsPalindrome method with an empty string
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyStringException))]
        public void TestIsPalindromeWithAnEmptyString() {
            Assert.AreEqual(true, StringHelper.IsPalindrome(""));
        }
    }
}