using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Element<L>
    {
        private L data;

        public L Data
        {
            get { return data; }
            set { data = value; }
        }

        Element<L> next;

        internal Element<L> Next
        {
            get { return next; }
            set { next = value; }
        }
       
    }
}
