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
            MyInt a = new MyInt("d");
            MyInt b = new MyInt(154);
            MyInt c = new MyInt("-230");
            MyInt d = new MyInt();
            //MyInt e = new MyInt(e);
            MyInt g = new MyInt("222222222222222222222222222222222222222222222");
        }
        [TestCase]
        public void testAdd()
        {
            //MyInt c = a.add(b);
        }
    }
}
