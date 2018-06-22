using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree");
            BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
            binaryTree.CreateTree();
            binaryTree.Add(85);
            binaryTree.Add(5);
            binaryTree.Add(70);
            binaryTree.Add(55);
            int falseValue = 12;
            int trueValue = 70;
            bool findValueFalse = binaryTree.Search(binaryTree.Root , falseValue);
            bool findValueTrue = binaryTree.Search(binaryTree.Root, trueValue);
            binaryTree.Display();
            Console.WriteLine(falseValue + " : " +findValueFalse);
            Console.WriteLine(trueValue + " : " + findValueTrue);
            Console.ReadLine();
        }
    }
}
