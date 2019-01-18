using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 1);
            var MyDog = new Peanut("RUFF");
        }
    }

    class Peanut
    {
        public Peamut(string noise)
        {
            Console.WriteLine(noise);
        }
    }
}
