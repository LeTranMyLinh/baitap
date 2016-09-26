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
        {
            this.head = null;
        }
        public void addfirst (Element<L> e)
        {
            e.Next = head;
            this.head = e;
        }
 
        //in tat ca phan tu
        public void PrintList()
        {
            Element<L> point = head;
            while(point != null)
            {
                Console.WriteLine(point.Data);
                point = point.Next;
            }
        }
    }
}
