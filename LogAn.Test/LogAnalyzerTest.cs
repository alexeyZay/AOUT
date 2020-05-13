using NUnit.Framework;
using logAn;
namespace LogAn.Test
{
    [TestFixture]
    public class LogAnalyzerTest
    {
        private LogAnalyzer my_loganalyzer = null;
        [SetUp]
        public void Setup()
        {
            my_loganalyzer = new LogAnalyzer();
        }

        [Test][Category("Fast Tests")]
        public void IsFileNameValide_ValidFileUppercase_ReturnTrue()
        {
           // LogAnalyzer analyzer = new LogAnalyzer();
            bool result = my_loganalyzer.IsFileNameValid("somename.slf");
            Assert.IsTrue(result,"Extension is case sensitive for now");
        }
        [Test][Ignore("just for testing perpose")]
        public void IsFileNameValide_ValidFileLowercase_ReturnTrue()
        {
           // LogAnalyzer analyzer = new LogAnalyzer();
            bool result = my_loganalyzer.IsFileNameValid("somename.SLF");
            Assert.IsTrue(result, "Extension is case sensitive for now");
        }
        [Test]
        [TearDown]
        public void TearDown()
        {
            my_loganalyzer = null;
        }
    }
}