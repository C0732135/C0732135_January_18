using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732135
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 1);
            var myDog = new peanut("RUFF");
        }
    }
    class peanut
    {
        public peanut(string noise)
        {
            Console.WriteLine(noise);
        }
    }
}
