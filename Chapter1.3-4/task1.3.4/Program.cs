using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = from path in Directory.GetFiles(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\Files"), "*.*", SearchOption.AllDirectories)
                        let file = new FileInfo(path)
                        select file.Length;

            var fileTotals = files.Aggregate((current, next) => current + next);
            Console.WriteLine(fileTotals);

            Console.ReadKey();

        }
    }
}
