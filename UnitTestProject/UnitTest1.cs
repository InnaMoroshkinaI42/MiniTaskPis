using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MiniTask;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = FormatTextProgramm.FormatText(10, "Проверка");
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestCanFormat()
        {
            bool result = FormatTextProgramm.CanFormat(10, "Проверка2");
            Assert.IsTrue(result);
        }
    }
}
