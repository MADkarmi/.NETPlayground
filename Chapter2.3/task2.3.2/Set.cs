using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3._2
{
    class Set : ArrayList
    {
        public Set() : base()
        {

        }

        public Set(ICollection c) : base()
        {
            AddRange(c);
        }

        public Set(Int32 capacity) : base(capacity)
        {

        }

        public override int Add(object value)
        {
            if (base.Contains(value))
            {
                return 0;
            }
            else
            {
                return base.Add(value);
            }
        }

        public override void AddRange(ICollection c)
        {
            foreach (Object item in c)
            {
                Add(item);
            }
        }

        public override void Insert(int index, object value)
        {
            throw new NotSupportedException();
        }

        public override void InsertRange(int index, ICollection c)
        {
            throw new NotSupportedException();
        }
    }
}
