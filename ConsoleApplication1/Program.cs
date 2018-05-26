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
            MyInt a = new MyInt(-5986551111111114);  
            MyInt b = new MyInt("5777777777777777777788888888888888888888888888885");
            MyInt d = a.add(b);
            //int c = a.compareTo(b);
            Console.WriteLine(d.number);
            //Console.WriteLine(c);
            Console.ReadKey();    

        }
    }
}
