using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3._4
{
    class Queue
    {
        private Queue<string> kolejka;
        private static readonly object lockK = new object();

        public Queue()
        {
            this.kolejka = new Queue<string>();
        }

        public Queue<string> Kolejka
        {
            get
            {
                lock (lockK)
                {
                    return kolejka;
                }
            }
        }
    }
}
