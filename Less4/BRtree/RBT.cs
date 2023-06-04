using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BRtree
{
    public class RBT<T> where T : IComparable<T>
    {
        public Node? root;

        internal enum Color 
        {
            Red, Black
        }

        public class Node
        {
            internal Node left;
            internal Node right;
            internal T Value;
            internal Color color;

            internal Node(T Value) 
            {
                this.Value = Value;
                left = null;
                right = null;
                color = Color.Red;
            }

            public override string ToString() 
            {
                return "Node: " + "value: " + Value + "left: " + left + "right: " + right + "color: " + color;
            }
        }

        private Node RotateRigth(Node node) 
        {
            Node child = node.right;
            Node childLeft = node.left;
            child.left = node;
            node.right = childLeft;
            return child;
        }

        private Node RotateLeft(Node node)
        {
            Node child = node.left;
            Node childRight = node.right;
            child.right = node;
            node.left = childRight;
            return child;
        }

        private bool IsRed(Node node) 
        {
            return node!= null && node.color.Equals(Color.Red);
        }

        private void SwapColors(Node firstNode, Node secondNode) 
        {
            Color temp = firstNode.color;
            firstNode.color = secondNode.color;
            secondNode.color = temp;
        }

        public bool Insert(T value) 
        {
            Node node;
            if (root != null)
            {
                node = Insert(root, value);
                if (node == null)
                {
                    return false;
                }
            }
            else
            {
                node = new Node(value);
            }
            root = node;
            root.color = Color.Black;
            return true;
        }


        private Node Insert(Node node, T value) 
        {
            if (node == null)
            {
                return new Node(value);
            }
            if (node.Value.CompareTo(value)>0)
            {
                node.left = Insert(node.left, value);
            }
            if (node.Value.CompareTo(value) < 0)
            {
                node.right = Insert(node.right, value);
            }
            else
            {
                return null;
            }

            return Balanced(node);
        }

        internal Node Balanced(Node node) 
        {
            if (IsRed(node.right)&&!IsRed(node.left))
            {
                node = RotateLeft(node);
                SwapColors(node, node.left);
            }

            if (IsRed(node.left) && IsRed(node.left.left))
            {
                node = RotateRigth(node);
                SwapColors(node, node.right);
            }

            if (IsRed(node.left)&&IsRed(node.right))
            {
                node.color = Color.Red;
                node.left.color = Color.Black;
                node.right.color = Color.Black;
            }

            return node;
        }

        public void InOrder() 
        {
            InOrder(root);
        }

        private void InOrder(Node node) 
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.WriteLine($"{node.Value} {node.color} |");
                InOrder(node.right);
            }
        }
    }
}
