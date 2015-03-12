using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerCruncher;
using System.Diagnostics;

namespace PowerCruncherTests
{
    [TestClass]
    public class PowerCruncherTests
    {
        [TestMethod]
        public void Test98765InBaseTenDigits()
        {
            var subject = new PowerCruncher.PowerCruncher();
            subject.formatString = "{1}";
            subject.joinString = "";
            Assert.AreEqual("98765", subject.getPowers(98765, 10) );
        }

        [TestMethod]
        public void Test97InBinaryDigits()
        {
            var subject = new PowerCruncher.PowerCruncher();
            subject.formatString = "{1}";
            subject.joinString = "";
            Assert.AreEqual("1100001", subject.getPowers(97, 2));
        }

        [TestMethod]
        public void Test43InOctalDigits()
        {
            var subject = new PowerCruncher.PowerCruncher();
            subject.formatString = "{1}";
            subject.joinString = "";
            Assert.AreEqual("53", subject.getPowers(43, 8));
        }

        //3 = 2(0) + 2 (1) 
        [TestMethod]
        public void Test3InBinaryWithElenaFormatting()
        {
            var subject = new PowerCruncher.PowerCruncher();
            subject.formatString = "{0}({1})";
            Assert.AreEqual("2(1) + 1(1)", subject.getPowers(3, 2));
        }

        [TestMethod]
        public void Test67InBinaryWithDefaultFormatting()
        {
            var subject = new PowerCruncher.PowerCruncher();
            Assert.AreEqual("2^6x1 + 2^5x0 + 2^4x0 + 2^3x0 + 2^2x0 + 2^1x1 + 2^0x1", subject.getPowers(67, 2));
        }

        [TestMethod]
        public void Test67InDecimalWithColumnMultipliedFormatting()
        {
            var subject = new PowerCruncher.PowerCruncher();
            subject.formatString = "{0}x{1}";
            Assert.AreEqual("10x6 + 1x7", subject.getPowers(67, 10));
        }

    }
}
