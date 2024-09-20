using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._6
{
    class Program
    {
        static void Main(string[] args)
        {

            var ips = from log in File.ReadAllLines(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\logs.txt"))
                      let searched = log.Split(' ')
                      group searched by searched[1] into a
                      orderby a.Count() descending
                      select new { ip = a.Key, count = a.Count() };
            
            foreach (var ip in ips.Take(3))
                Console.WriteLine("{0}: {1}",ip.ip, ip.count);
            Console.ReadKey();
        }
    }
}
