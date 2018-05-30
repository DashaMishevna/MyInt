using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace Test
{
    [TestClass]
    public class TestDEQueue
    {
        [TestMethod]
        public void testCreateDEQueue()
        {
            DEQueue<int> a = new DEQueue<int>();
            DEQueue<MyInt> d = new DEQueue<MyInt>();
            Assert.IsTrue(a.Count == 0);
            Assert.IsTrue(d.Count == 0);
        }

        [TestMethod]
        public void testPushBackOne()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            Assert.IsTrue(b.Count == 1);
            foreach (var x in b)
            {
                Assert.AreEqual("abc", x);
            }
        }

        [TestMethod]
        public void testPushBackMany()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.IsTrue(b.Count == 2);
            Assert.AreEqual("cba", b.back());
        }

        [TestMethod]
        public void testPushFrontOne()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            Assert.IsTrue(b.Count == 1);
            foreach (var x in b)
            {
                Assert.AreEqual("abc", x);
            }
        }

        [TestMethod]
        public void testPushFrontMany()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.IsTrue(b.Count == 2);
            Assert.AreEqual("abc", b.front());
        }

        [TestMethod]
        public void testPopBack()
        {
            DEQueue<string> b = new DEQueue<string>();
            Assert.AreEqual(null, b.popBack());
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.AreEqual("cba", b.popBack());
            Assert.IsTrue(b.Count == 1);
        }

        [TestMethod]
        public void testPopFront()
        {
            DEQueue<string> b = new DEQueue<string>();
            Assert.AreEqual(null, b.popFront());
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.AreEqual("abc", b.popFront());
            Assert.IsTrue(b.Count == 1);
        }

        [TestMethod]
        public void testBack()
        {
            DEQueue<string> b = new DEQueue<string>();
            Assert.AreEqual(null, b.back());
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.AreEqual("cba", b.back());
            Assert.IsTrue(b.Count == 2);
        }

        [TestMethod]
        public void testFront()
        {
            DEQueue<string> b = new DEQueue<string>();
            Assert.AreEqual(null, b.front());
            b.pushBack("abc");
            b.pushBack("cba");
            Assert.AreEqual("abc", b.front());
            Assert.IsTrue(b.Count == 2);
        }

        [TestMethod]
        public void testSize()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            Assert.AreEqual(1, b.size());
        }

        [TestMethod]
        public void testClear()
        {
            DEQueue<string> b = new DEQueue<string>();
            b.pushBack("abc");
            b.clear();
            Assert.IsTrue(b.Count == 0);
        }

        [TestMethod]
        public void testToArray()
        {
            DEQueue<string> b = new DEQueue<string>();
            Assert.AreEqual(null, b.toArray());
            b.pushBack("abc");
            b.pushBack("cba");
            string[] arr = b.toArray();
            Assert.AreEqual("abc", arr[0]);
            Assert.AreEqual("cba", arr[1]);
        }
    }
}
