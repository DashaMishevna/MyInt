using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace Test
{
    [TestClass]
    class TestDEQueue
    {
        [TestMethod]
        public void testCreate()
        {
            DEQueue<int> a = new DEQueue<int>();
            DEQueue<MyInt> d = new DEQueue<MyInt>();
            Assert.IsTrue(a.Count == 0);
            Assert.IsTrue(d.Count == 0);
        }

        [TestMethod]
        public void testPushBack()
        {
            //DEQueue<string> b = new DEQueue<string>();
            //b.pushBack("abc");
            //Assert.IsTrue(b.Count == 1);
            //foreach (var x in b) // Ошибочка
            //{
            //    Assert.AreEqual("abc", x);
            //}
        }

        [TestMethod]
        public void testPushFront()
        {

        }

        [TestMethod]
        public void testPopBack()
        {

        }

        [TestMethod]
        public void testPopFront()
        {

        }

        [TestMethod]
        public void testBack()
        {

        }

        [TestMethod]
        public void testFront()
        {

        }

        [TestMethod]
        public void testSize()
        {

        }

        [TestMethod]
        public void testClear()
        {

        }

        [TestMethod]
        public void testToArray()
        {

        }
    }
}
