using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2._3._4
{
    class Golibroda
    {
        Queue kolejka;
        public Golibroda(Queue kolejka)
        {
            this.kolejka = kolejka;
        }

        public void Run()
        {
            while (true)
            {
                if (kolejka.Kolejka.Count == 0)
                {
                    Thread.CurrentThread.Suspend();
                }
                else
                {
                    kolejka.Kolejka.Dequeue();
                }
            }
        }
    }
}
