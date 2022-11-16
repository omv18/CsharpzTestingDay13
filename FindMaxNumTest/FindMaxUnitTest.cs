using CsharpzTestingDay;
using System.IO;
using System;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = findMax.MaxNumber("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = findMax.MaxNumber("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = findMax.MaxNumber("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}