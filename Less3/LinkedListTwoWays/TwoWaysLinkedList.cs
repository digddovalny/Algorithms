using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTwoWays
{
    internal class TwoWaysLinkedList
    {
        private Node head;
        private Node tail;

        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            if (head != null)
            {
                toAdd.next = head;
                head.previous = toAdd;
            }
            else
            {
                tail = toAdd;
            }
            head = toAdd;
        }
        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        public bool FindElement(int value)
        {
            Node i = head;
            while (i != null)
            {
                if (i.data == value)
                {
                    return true;
                }
                i = i.next;
            }
            return false;
        }

        public void AddLast(int data)
        {
            Node toAddLast = new Node();
            Node i = head;
            toAddLast.data = data;
            if (head == null)
            {
                head = toAddLast;
            }
            else
            {
                while (i.next != null)
                {
                    i = i.next;
                }
                i.next = toAddLast;
            }
        }

        public void DeleteLast()
        {
            if (head != null)
            {
                Node i = head;
                while (i.next != null)
                {
                    if (i.next.next == null)
                    {
                        i.next = null;
                        return;
                    }
                    i = i.next;
                }
                head = null;
            }
        }
    }
}
