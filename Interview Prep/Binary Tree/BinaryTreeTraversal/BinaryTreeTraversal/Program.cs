using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversal
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            this.Data = data;
        }
    }

    class BinaryTree
    {
        public Node Root;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);
            binaryTree.Root.Left.Right.Left = new Node(6);
            binaryTree.Root.Left.Right.Right = new Node(7);

            Console.WriteLine("Preorder traversal with recursion");
            Preorder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Preorder traversal without recursion");
            PreorderWithoutRecursion(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Inorder traversal with recursion");
            Inorder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Inorder traversal without recursion");
            InorderWithoutRecursion(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Postorder traversal with recursion");
            Postorder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Postorder traversal with recursion using 2 stacks");
            PostorderWithoutRecursionTwoStacks(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Postorder traversal with recursion using 1 stack");
            PostOrderRecursionWithOneStack(binaryTree.Root);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Preorder(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.Data + " ");
            Preorder(root.Left);
            Preorder(root.Right);
        }

        static void PreorderWithoutRecursion(Node root)
        {
            if (root != null)
            {                
                Stack<Node> stack = new Stack<Node>();
                stack.Push(root);

                while (stack.Count > 0)
                {
                    Node current = stack.Pop();
                    Console.Write(current.Data + " ");

                    if (current.Right != null)
                    {
                        stack.Push(current.Right);
                    }

                    if (current.Left != null)
                    {
                        stack.Push(current.Left);
                    }
                }                
            }
        }

        static void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.Left);
            Console.Write(root.Data + " ");            
            Inorder(root.Right);
        }

        static void InorderWithoutRecursion(Node root)
        {
            if (root != null)
            {
                Stack<Node> stack = new Stack<Node>();
                Node current = root;

                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                while (stack.Count > 0)
                {
                    current = stack.Pop();
                    Console.Write(current.Data + " ");

                    if (current.Right != null)
                    {                        
                        current = current.Right;

                        while (current != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }                    
                }
            }
        }

        static void Postorder(Node root)
        {
            if (root == null)
                return;

            Postorder(root.Left);
            Postorder(root.Right);
            Console.Write(root.Data + " ");            
        }

        static void PostorderWithoutRecursionTwoStacks(Node root)
        {
            if (root != null)
            {
                Stack<Node> stagingStack = new Stack<Node>();
                Stack<Node> printingStack = new Stack<Node>();                
                stagingStack.Push(root);

                while (stagingStack.Count > 0)
                {
                    Node temp = stagingStack.Pop();
                    printingStack.Push(temp);

                    if (temp.Left != null)
                    {
                        stagingStack.Push(temp.Left);
                    }

                    if (temp.Right != null)
                    {
                        stagingStack.Push(temp.Right);
                    }
                }

                while (printingStack.Count > 0)
                {
                    Console.Write(printingStack.Pop().Data + " ");
                }
            }
        }

        static void PostOrderRecursionWithOneStack(Node root)
        {
            if (root != null)
            {
                Node current = root;
                Stack<Node> stack = new Stack<Node>();

                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                Node lastPrintedNode = null;
                while (stack.Count > 0)
                {
                    Node temp = stack.Peek();                    

                    if (temp.Right != null && temp.Right != lastPrintedNode)
                    {
                        current = temp.Right;
                        
                        while (current != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }
                    else
                    {
                        lastPrintedNode = stack.Pop();
                        Console.Write(lastPrintedNode.Data + " ");
                    }
                }
            }
        }
    }    
}
