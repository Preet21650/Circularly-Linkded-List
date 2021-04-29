using System;
using System.Collections.Generic;
using System.Text;

namespace Circularly_Linkded_List
{
    class Node
    {
        public string name;
        public Node next;

        public Node(string name, Node next)
        {
            this.name = name;
            this.next = next;
        }
    }

}
