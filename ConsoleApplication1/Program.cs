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
            MyInt a = new MyInt(154);   
            MyInt b = new MyInt("-230");     
            MyInt c = a.add(b);      
        }
    }
}
