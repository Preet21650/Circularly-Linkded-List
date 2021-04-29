using System;
using System.Collections.Generic;
using System.Text;

namespace Circularly_Linkded_List
{
    class CircularlyLinkedList
    {
        Node head = null;

        public CircularlyLinkedList()
        {

        }

        public void Add(string name)
        {
            if (head == null)
            {
                head = new Node(name, null);
                head.next = head;
            }
            else
            {
                Node current = head;
                while(current.next != head)
                {
                    current = current.next;
                }
                Node newNode = new Node(name, null);
                current.next = newNode;
                newNode.next = head;
            }

        }

        public void PrintList()
        {
            if(head != null)
            {
                Node current = head;
                while (current.next != head)
                {
                    Console.WriteLine(current.name);
                    current = current.next;
                  
                }
                Console.WriteLine(current.name);
            }
        }
    }

}
