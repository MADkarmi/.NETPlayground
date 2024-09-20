using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            Console.WriteLine(reader.read("temp"));
            Console.ReadKey();
        }
    }
}
