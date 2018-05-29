using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testCreate()
        {
            MyInt a = new MyInt("-5");
            MyInt b = new MyInt(154);
            MyInt c = new MyInt("-230");
            MyInt d = new MyInt();
            byte[] e = new byte[] { 0, 5, 0, 0 };
            MyInt g = new MyInt("222222222222222222222222222222222222222222222");
            Assert.AreEqual("-5", a.number);
            Assert.AreEqual("154", b.number);
            Assert.AreEqual("-230", c.number);
            Assert.AreEqual("", d.number);
            Assert.AreEqual("500", e);
            Assert.AreEqual("222222222222222222222222222222222222222222222", g.number);

        }

        [TestMethod]
        public void testAdd()
        {
            MyInt a = new MyInt("-5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("10");
            MyInt b1 = new MyInt(-9);

            MyInt a2 = new MyInt("0");
            MyInt b2 = new MyInt(7);

            MyInt a3 = new MyInt("-3");
            MyInt b3 = new MyInt(-11);

            Assert.AreEqual("-4", a.add(b).number);
            Assert.AreEqual("1", a1.add(b1).number);
            Assert.AreEqual("7", a2.add(b2).number);
            Assert.AreEqual("-14", a3.add(b3).number);
        }

        [TestMethod]
        public void testSubstract()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);
            
            MyInt a2 = new MyInt("-5");
            MyInt b2 = new MyInt(1);
            
            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("", a.subtract(b).number);
            Assert.AreEqual("", a1.subtract(b1).number);
            Assert.AreEqual("", a2.subtract(b2).number);
            Assert.AreEqual("", a3.subtract(b3).number);
        }

        [TestMethod]
        public void testMultiply()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("-5");
            MyInt b2 = new MyInt(1);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.multiply(b).number);
            Assert.AreEqual("-39", a1.multiply(b1).number);
            Assert.AreEqual("-5", a2.multiply(b2).number);
            Assert.AreEqual("12", a3.multiply(b3).number);
        }

        [TestMethod]
        public void testMax()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("-5");
            MyInt b2 = new MyInt(1);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.max(b).number);
            Assert.AreEqual("13", a1.max(b1).number);
            Assert.AreEqual("1", a2.max(b2).number);
            Assert.AreEqual("-2", a3.max(b3).number);
        }

        [TestMethod]
        public void testMin()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("-5");
            MyInt b2 = new MyInt(1);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("1", a.min(b).number);
            Assert.AreEqual("-3", a1.min(b1).number);
            Assert.AreEqual("-5", a2.min(b2).number);
            Assert.AreEqual("-6", a3.min(b3).number);
        }

        [TestMethod]
        public void testAbs()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("-5");
            MyInt b2 = new MyInt(1);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.abs().number);
            Assert.AreEqual("13", a1.abs().number);
            Assert.AreEqual("5", a2.abs().number);
            Assert.AreEqual("6", a3.abs().number);
        }

        [TestMethod]
        public void testCompareTo()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("4");
            MyInt b2 = new MyInt(4);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("", a.compareTo(b));
            Assert.AreEqual("", a1.compareTo(b1));
            Assert.AreEqual("0", a2.compareTo(b2));
            Assert.AreEqual("", a3.compareTo(b3));
        }


        [TestMethod]
        public void testGcd()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("24");
            MyInt b1 = new MyInt(-12);

            MyInt a2 = new MyInt("4");
            MyInt b2 = new MyInt(4);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.gcd(b).number);
            Assert.AreEqual("12", a1.gcd(b1).number);
            Assert.AreEqual("4", a2.gcd(b2).number);
            Assert.AreEqual("2", a3.gcd(b3).number);
        }


        [TestMethod]
        public void testToString()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("4");
            MyInt b2 = new MyInt(4);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.toString());
            Assert.AreEqual("13", a1.toString());
            Assert.AreEqual("4", a2.toString());
            Assert.AreEqual("-6", a3.toString());
        }


        [TestMethod]
        public void testLongValue()
        {
            MyInt a = new MyInt("5");
            MyInt b = new MyInt(1);

            MyInt a1 = new MyInt("13");
            MyInt b1 = new MyInt(-3);

            MyInt a2 = new MyInt("4");
            MyInt b2 = new MyInt(4);

            MyInt a3 = new MyInt("-6");
            MyInt b3 = new MyInt(-2);

            Assert.AreEqual("5", a.longValue());
            Assert.AreEqual("13", a1.longValue());
            Assert.AreEqual("4", a2.longValue());
            Assert.AreEqual("-6", a3.longValue());
        }
    }
}
