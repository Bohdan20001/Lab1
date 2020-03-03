using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double r = 3;
            double h = 10;
            double result = my_project.Program.Example(r, h);
            double result1 = my_project.Program.Example1(r, h);
            Assert.AreEqual(188.4, result);
            Assert.AreEqual(282.6, result1);
        }
    }
}
