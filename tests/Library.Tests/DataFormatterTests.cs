using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFormatCorrect()
    {
        string expected = "1997-12-10";
        string testDate = "10/12/1997";
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