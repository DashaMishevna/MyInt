using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyInt a = new MyInt("99999999999999999999999999999999");
            MyInt b = new MyInt("999999999999999999999999999999999999999999");
            MyInt c = a.multiply(b);
            Console.WriteLine(c.number);
            Console.ReadKey();
        }
    }
}
