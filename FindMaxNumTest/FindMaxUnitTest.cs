using CsharpzTestingDay;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMax.MaxNumber(40, 20, 30);
            Assert.AreEqual(40, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMax.MaxNumber(20, 40, 30);
            Assert.AreEqual(40, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMax.MaxNumber(20, 30, 40);
            Assert.AreEqual(40, result);
        }
    }
}