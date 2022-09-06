using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Tree
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int element, Node left, Node right)
        {
            this.element = element;
            this.left = left;
            this.right = right;
        }
    }
    internal class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(Node temproot, int e)
        {
            Node temp = null;
            while(temproot != null)
            {
                temp = temproot;
                if(e==temproot.element)
                {
                    return;
                }
                else if(e<temproot.element)
                {
                    temproot = temproot.left;
                }
                else if(e>temproot.element)
                {
                    temproot =temproot.right;
                }
            }
            Node n = new Node(e,null,null);
            if (root != null)
            {
                if (e < temp.element)
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            else
                root = n;
        }
        public void inorder(Node temproot)
        {
            if (temproot!=null)
            {
                inorder(temproot.left);
                Console.WriteLine("The element is: "+temproot.element);
                inorder(temproot.right);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search tree");
            BinarySearchTree B = new BinarySearchTree();
            Console.WriteLine("Enter 1 for entering the elements");
            Console.WriteLine("Enter 2 for seening the elements");
            int ans=Convert.ToInt32(Console.ReadLine());
            switch(ans)
            {
                case 1: B.insert(B.root, 56); //UC1 
                        B.insert(B.root, 30);
                        B.insert(B.root, 70);
                        break;
                case 2:
                    B.insert(B.root, 56); //UC2
                    B.insert(B.root, 30);
                    B.insert(B.root, 70);
                    B.insert(B.root, 22);
                    B.insert(B.root, 40);
                    B.insert(B.root, 60);
                    B.insert(B.root, 95);
                    B.insert(B.root, 11);
                    B.insert(B.root, 65);
                    B.insert(B.root, 3);
                    B.insert(B.root, 16);
                    B.insert(B.root, 63);
                    B.insert(B.root, 67);
                    B.inorder(B.root);
                        break;
                default: Console.WriteLine("Null Value"); break;
            }
        }
    }
}