using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] numbersFile = File.ReadAllLines(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\RandomIntegers.txt"));
            List<int> listofnumbers = new List<int>();
            int value = 0;
            foreach (string text in numbersFile)
            {                
                Int32.TryParse(text, out value);
                listofnumbers.Add(value);
                
            }

            var result = from number in listofnumbers
                         where number >= 100
                         orderby number descending
                         select number;
            

            foreach (var number in result)
                Console.WriteLine(number);
            Console.WriteLine("\nFirstend \n");

            var tmp = listofnumbers.Where(element => element >= 100).OrderByDescending(element => element);

            foreach (var number in tmp)
                Console.WriteLine(number);
            Console.WriteLine("\nEnd");
            Console.ReadKey();
        }
    }
}
