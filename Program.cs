using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_console
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Was is uw naam?");

            string ingevuld = Console.ReadLine();
            Console.WriteLine($"Hallo {ingevuld}" );

            
            Console.ReadLine();
        }

       
        
        
    }
}
