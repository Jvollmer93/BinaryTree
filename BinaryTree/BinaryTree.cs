using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.BinaryTree
{
    class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        public BinaryTree()
        {
            root = null;
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        public void Display(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.rightChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.data);

            Display(node.leftChild, level + 1);
        }
        public void CreateTree()
        {
            root = new Node(50);
            root.leftChild = new Node(25);
            root.rightChild = new Node(75);
            root.leftChild.leftChild = new Node(10);
            root.leftChild.rightChild = new Node(40);
            root.rightChild.leftChild = new Node(60);
        }
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public bool Search(Node node, int value)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.data == value)
            {
                return true;
            }
            else if (node.data < value)
            {
                return Search(node.rightChild, value);
            }
            else if (node.data > value)
            {
                return Search(node.leftChild, value);
            }
            return false;
        }
    }
}
