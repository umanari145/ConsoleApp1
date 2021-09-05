using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SchoolGetter sc = new ConsoleApp1.SchoolGetter();
            string msg = sc.TestDayo();
            Assert.AreEqual("本日は晴天なり", msg);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SchoolGetter sc = new ConsoleApp1.SchoolGetter();
            string msg = sc.TestDayo();
            Assert.AreEqual("本日は晴天なりa", msg);
        }

        [TestMethod]
        public void TestMethod3()
        {
            SchoolGetter sc = new ConsoleApp1.SchoolGetter();
            string msg = sc.TestDayo();
            Assert.AreEqual("本日は晴天なり", msg);
        }
    }
}
