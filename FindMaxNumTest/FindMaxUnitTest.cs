using CsharpzTestingDay;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = findMax.MaxNumber(5.7f, 5.5f, 5.3f);
            Assert.AreEqual(5.7f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = findMax.MaxNumber(5.5f, 5.7f, 5.3f);
            Assert.AreEqual(5.7f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = findMax.MaxNumber(5.3f, 5.5f, 5.7f);
            Assert.AreEqual(5.7f, result);
        }
    }
}