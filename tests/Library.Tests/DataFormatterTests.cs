using TestDateFormat;
namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    public class DateFormatterTest
    {
        [Test]
        public void TestFormatCorrect()
        {
            string expected = "1997-11-10";
            string testDate = "10/11/1997";
            Assert.AreEqual(DateFormatter.ChangeFormat(testDate), expected);
        }
        [Test]
        public void TestWrongFormat()
        {
            string expected = null;
            string testDate = "1011/1997";
            Assert.AreEqual(DateFormatter.ChangeFormat(testDate), expected);
        }
        [Test]
        public void TestEmpty()
        {
            string expected = null;
            string testDate = "";
            Assert.AreEqual(DateFormatter.ChangeFormat(testDate), expected);
        }
    }
}