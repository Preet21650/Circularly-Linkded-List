using System;

namespace Circularly_Linkded_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularlyLinkedList mylist = new CircularlyLinkedList();

            mylist.Add("Preet");
            mylist.Add("James");
            mylist.Add("Josh");
            mylist.Add("Phil");

            mylist.PrintList();

        }
    }
}
