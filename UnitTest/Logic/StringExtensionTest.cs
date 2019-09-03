using Logic;
using Logic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Logic {

    /// <summary>
    /// The StringExtensionTest contains methods to test the StringExtension class
    /// </summary>
    [TestClass]
    public class StringExtensionTest {

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
            var word = "ibofobi";
            Assert.AreEqual(true, word.IsPalindrome());
        }

        /// <summary>
        /// Test the IsPalindrome method with an empty string
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyStringException))]
        public void TestIsPalindromeWithAnEmptyString() {
            var word = "";
            Assert.AreEqual(true, word.IsPalindrome());
        }
    }
}