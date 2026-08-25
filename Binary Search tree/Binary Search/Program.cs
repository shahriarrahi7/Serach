using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        class Node
        {
            public int Data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                Data = data;
                left = null;
                right = null;
            }
        }

        class BinarySearchTree
        {
            public Node root;

            public void Insert(int val)
            {
                root = InsertNode(root, val); 
            }

            private Node InsertNode(Node root, int val)
            {
                if(root == null)
                    return new Node(val);
                if(root.Data > val)
                    root.left = InsertNode(root.left, val);
                if(root.Data < val)
                    root.right = InsertNode(root.right, val);
                return root;
            }

            public bool Search(Node root, int val)
            {
                if(root == null)
                   return false;
                if(root.Data == val)
                    return true;
                if(root.Data > val)
                    return Search(root.left, val);
                return Search(root.right, val);
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);

            Console.WriteLine(tree.Search(tree.root, 9));
        }
    }
}
