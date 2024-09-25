using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinefieldTask
{
    class Node
    {
        public Node()
        {
        }

        public Node(int r, int c)
        {
            this.r = r;
            this.c = c;
        }

        public int r { get; set; }
        public int c { get; set; }

        public void printNode()
        {
            Console.WriteLine("row : " + r + " col : " + c);
        }

    }
}
