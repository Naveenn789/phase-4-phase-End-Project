using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Equal()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
