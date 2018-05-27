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
            //MyInt a = new MyInt("-123456789123456789123156");
            ////byte[] a = new byte[] { 0, 5,0,0 };
            ////MyInt c = new MyInt(a);
            //MyInt b = new MyInt("-100");
            ////byte[] w = new byte();
            //long d = a.longValue();
            ////int c = a.compareTo(b);
            //Console.WriteLine(d);
            ////Console.WriteLine(c);
            //Console.ReadKey();

            DEQueue<MyInt> queue = new DEQueue<MyInt>();
            MyInt a = new MyInt("123123");
            MyInt b = new MyInt("456789456");
            //MyInt d = new MyInt();
            //Console.WriteLine(d.number);
            queue.pushBack(a);
            //queue.pushBack(d);
            //Console.WriteLine(queue.front());
            //queue.pushBack(a);
            //queue.pushFront(b);
            //MyInt[] arr = queue.toArray();
            //foreach (var x in arr)
            //{
            //    Console.WriteLine(x.number);
            //}
            Console.ReadKey();
        }
    }
}
