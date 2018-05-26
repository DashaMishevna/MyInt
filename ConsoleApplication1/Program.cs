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
            MyInt a = new MyInt(-9);  
            MyInt b = new MyInt("1");
            MyInt d = a.multiply(b);
            //int c = a.compareTo(b);
            Console.WriteLine(d.number);
            //Console.WriteLine(c);
            Console.ReadKey();    

        }
    }
}
