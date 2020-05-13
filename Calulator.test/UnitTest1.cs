using NUnit.Framework;

namespace AOUT.CH2.Calc.Tests
{
    public class Tests
    {
        private Calculator c = null;
        [SetUp]
        public void Setup()
        {
             c = new Calculator();
        }

        [Test]
        public void Sum_NoAddCalled_Zeroresult()
        {
            int sum = c.Sum();
            Assert.AreEqual(0,sum);
        }
        [Test]
        public void Sum_AddCalled_ReturnOne()
        {
            c.Add(2);
            int sum = c.Sum();
            Assert.AreEqual(2, sum);
        }
    }
}