using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [TestFixture]
    class TestMyInt
    {
        [TestCase]
        public void testCreate()
        {
            MyInt a = new MyInt("-5");
            MyInt b = new MyInt(154);
            MyInt c = new MyInt("-230");
            MyInt d = new MyInt();
            byte[] e = new byte[] { 0, 5,0,0 };
            MyInt g = new MyInt("222222222222222222222222222222222222222222222");
            Console.Write("Работает");
            Console.ReadKey();
        }
        [TestCase]
        public void testAdd()
        {
            MyInt a = new MyInt("-5");
            MyInt b = new MyInt(1);
            MyInt c = a.add(b);
            MyInt a1 = new MyInt("10000000000000000000");
            MyInt b1 = new MyInt(-99999999999999);
            MyInt c1 = a1.add(b1);

        }
    }
}
