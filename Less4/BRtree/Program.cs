using BRtree;

class Program
{
    static void Main(string[] args)
    {
        RBT<int> tree = new RBT<int>();

        tree.Insert(10);
        tree.InOrder();
        tree.Insert(20);
        tree.InOrder();
        tree.Insert(30);
        tree.InOrder();
        tree.Insert(-22);
        tree.InOrder();




    }
}