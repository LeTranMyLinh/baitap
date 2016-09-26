using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List<L>
    {
        Element<L> head;

        internal Element<L> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List()
        { }
        public void addfirst (Element<L> e)
        {
            e.Next = head;
            this.head = e;
        }
    }
}
