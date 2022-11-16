using CsharpzTestingDay;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenIntMaxFirstNum_WhenAnalysed_ShouldReturnIntFirstMax()
        {
            int result = findMax.MaxNumber(40, 20, 30);
            Assert.AreEqual(40, result);
        }
        [Test]
        public void GivenIntMaxSecondNum_WhenAnalysed_ShouldReturnIntSecondMax()
        {
            int result = findMax.MaxNumber(20, 40, 30);
            Assert.AreEqual(40, result);
        }
        [Test]
        public void GivenIntMaxThirdNum_WhenAnalysed_ShouldReturnIntThirdMax()
        {
            int result = findMax.MaxNumber(20, 30, 40);
            Assert.AreEqual(40, result);
        }
        [Test]
        public void GivenStringMaxFirstNum_WhenAnalysed_ShouldReturnStringFirstMax()
        {
            string result = findMax.MaxNumber("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenStringMaxSecondNum_WhenAnalysed_ShouldReturnStringSecondMax()
        {
            string result = findMax.MaxNumber("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenStringMaxThirdNum_WhenAnalysed_ShouldReturnStringThirdMax()
        {
            string result = findMax.MaxNumber("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
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