using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            if (head == null) return;
            Node current = head;
            do
            {
                Console.Write(current.data+" ");
                current = current.next;
            } while (current != null);
        }
        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            if (head != null)
            {
                toAdd.next = head;
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
        public void ReverseList() 
        {
            if (this.head != null)
            {
                Node prevNode = this.head;
                Node tempNode = this.head;
                Node currentNode = this.head.next;

                prevNode.next = null;

                while (currentNode != null)
                {
                    tempNode = currentNode.next;
                    currentNode.next = prevNode;
                    prevNode = currentNode;
                    currentNode = tempNode;
                }

                this.head = prevNode;
            }
        }
    }
}
