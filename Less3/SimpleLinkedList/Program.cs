using SimpleLinkedList;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args) 
    {
        LinkedList linkedList = new LinkedList();
        Node head = null;
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);

        linkedList.ReverseList();
        linkedList.printAllNodes();
    }
}