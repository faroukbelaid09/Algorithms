using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BST
{
    public class Node
    {
        public int Value {  get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value) 
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root { get; private set; }
        public BinarySearchTree(int value)
        {
            this.Root = new Node(value);
        }

        private void InsertLeft(Node node, int value)
        {
            if(node.Left == null)
            {
                node.Left = new Node(value);
            }
            else if(value < node.Left.Value)
            {
                InsertLeft(node.Left, value);
            }
            else
            {
                InsertRight(node.Left, value);
            }
        }

        private void InsertRight(Node node, int value)
        {
            if (node.Right == null)
            {
                node.Right = new Node(value);
            }
            else if (value > node.Right.Value)
            {
                InsertRight(node.Right, value);
            }
            else
            {
                InsertLeft(node.Right, value);
            }
        }
        
        public void Insert(int value)
        {
            if (this.Root == null)
            {
                this.Root = new Node(value);
                return;
            }

            if(value < this.Root.Value)
            {
                InsertLeft(this.Root,value);
            }
            else
            {
                InsertRight(this.Root,value);
            }
        }

        // Method to visually print the tree structure
        public void PrintTree()
        {
            PrintTree(this.Root, 0);
        }


        private void PrintTree(Node root, int space)
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if (root == null)
                return;


            space += COUNT;
            PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value); // Print the current node after space


            PrintTree(root.Left, space); // Recur on the left child
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree(45);

            binarySearchTree.Insert(15);

            binarySearchTree.Insert(79);
            binarySearchTree.Insert(90);

            binarySearchTree.Insert(10);
            binarySearchTree.Insert(55);

            binarySearchTree.Insert(12);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(50);

            binarySearchTree.PrintTree();
        }
    }
}