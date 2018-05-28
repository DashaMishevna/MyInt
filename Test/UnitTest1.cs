﻿using System;
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
            //MyInt c = new MyInt("-230");
            //MyInt d = new MyInt();
            //byte[] e = new byte[] { 0, 5, 0, 0 };
            //MyInt g = new MyInt("222222222222222222222222222222222222222222222");
            Assert.AreEqual("-5", a.number);
            Assert.AreEqual("154", b.number); 

        }

        [TestMethod]
        public void testAdd()
        {
            MyInt a = new MyInt("-5");
            MyInt b = new MyInt(1);
            MyInt c = a.add(b);
            MyInt a1 = new MyInt("10000000000000000000");
            MyInt b1 = new MyInt(-99999999999999);
            MyInt c1 = a1.add(b1);
            Assert.AreEqual("-4", a.add(b).number);
        }

        [TestMethod]
        public void testSubstract()
        {
            MyInt a = new MyInt("55555555");
            MyInt b = new MyInt(111111);
            MyInt c = a.subtract(b);
            MyInt a1 = new MyInt("-10000000000000000000");
            MyInt b1 = new MyInt(-99999999999999);
            MyInt c1 = a1.subtract(b1);
            MyInt a2 = new MyInt("-982874265");
            MyInt b2 = new MyInt(1);
            MyInt c2 = a2.subtract(b2);
            MyInt a3 = new MyInt("32165165487749865/874569846585982874265");
            MyInt b3 = new MyInt(-73888225555588888);
            MyInt c3 = a3.subtract(b3);
        }
    }
}