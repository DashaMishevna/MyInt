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
            MyInt n = new MyInt("d");
        }
    }
}
