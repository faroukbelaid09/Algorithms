using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Node
    {
        public int Value {  get; set; }
        public Node Left { get; set; } 
        public Node Right { get; set; }

        public Node(int val) 
        {
            this.Value = val;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; private set; }

        public BinaryTree(int value)
        {
            this.Root = new Node(value);
        }

        public void Insert(int value)
        {
            if(this.Root == null)
            {
                this.Root = new Node(value);
                return;
            }

            Queue<Node> BinaryQueue = new Queue<Node>();
            BinaryQueue.Enqueue(this.Root);

            while (BinaryQueue.Count > 0) 
            {
                var current = BinaryQueue.Dequeue();

                if (current.Left == null)
                {
                    current.Left = new Node(value); ;
                    break;
                }
                else
                {
                    BinaryQueue.Enqueue(current.Left);
                }

                if (current.Right == null)
                {
                    current.Right = new Node(value);
                    break;
                }
                else
                {
                    BinaryQueue.Enqueue(current.Right);
                }
            }
        }
    }

   
    internal class Program
    {
        static void n(Node node)
        {
            if(node.Left != null)
            {

            }
        }

        static void BFS(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<Node> nodes = new Queue<Node>();

            nodes.Enqueue(root);
            while (nodes.Count > 0) 
            {
                Node current = nodes.Dequeue();
                Console.Write(current.Value + " ");

                if(current.Left != null)
                {
                    nodes.Enqueue(current.Left);
                }

                if (current.Right != null) 
                {
                    nodes.Enqueue(current.Right);
                }
            }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(0);

            tree.Insert(1);
            tree.Insert(2);

            tree.Insert(3);
            tree.Insert(4);

            tree.Insert(5);
            tree.Insert(6);

            BFS(tree.Root);
            //Console.WriteLine(tree.Root.Right.Value);
        }
    }
}