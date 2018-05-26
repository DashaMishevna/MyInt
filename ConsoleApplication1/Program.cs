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
            MyInt a = new MyInt(-1254);   
            MyInt b = new MyInt("2");  
           // MyInt c = a.add(b);
            MyInt d = a.multiply(b);
            Console.WriteLine(d.number);
            Console.ReadKey();    
        }
    }
}
