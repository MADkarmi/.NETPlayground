using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = from surname in File.ReadAllLines(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\Surnames.txt"))
                         orderby surname
                         group surname by surname[0] into g
                         select g.Key;

            foreach (var g in groups)
                Console.WriteLine(g);
            Console.ReadLine();
        }
    }
}
