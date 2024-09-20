using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            for(int i = 1; i < 100001; ++i)
            {
                Number current = new Number(i);
                if (i % current.DigitSum() == 0 && current.DevisableByAllDig())
                    Numbers.Add(i);
            }

            foreach(int x in Numbers)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }

    class Number
    {
        public int Value { get; set; }

        public Number(int v)
        {
            this.Value = v;
        }

        public List<int> Digits()
        {
            List<int> digits = new List<int>();
            int n = Value;
            while(n>0)
            {
                digits.Add(n % 10);
                n = n / 10;
            }
            return digits;
        }
        public int DigitSum()
        {
            return Digits().Sum();
        }

        public bool DevisableByAllDig()
        {
            return Digits().All(digit => digit != 0 && Value % digit == 0);
        }
    }
}
