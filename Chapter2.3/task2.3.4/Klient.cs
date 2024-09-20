using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2._3._4
{
    class Klient
    {
        Thread golibroda;
        Queue kolejka;
        public Klient(Thread golibroda, Queue kolejka)
        {
            this.golibroda = golibroda;
            this.kolejka = kolejka;
        }

        public void Run()
        {
            while (true)
            {
                if (golibroda.ThreadState == ThreadState.Suspended)
                {
                    golibroda.Resume();
                }
                else if (kolejka.Kolejka.Count <= 7)
                {
                    kolejka.Kolejka.Enqueue("klient");
                }
            }
        }
    }
}
