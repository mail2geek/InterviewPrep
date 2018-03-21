using System;
using System.Collections.Generic;

namespace LevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(20);
            binaryTree.Root.Left = new Node(8);
            binaryTree.Root.Right = new Node(22);
            binaryTree.Root.Right.Left = new Node(20);
            binaryTree.Root.Right.Right = new Node(24);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(12);
            binaryTree.Root.Left.Right.Left = new Node(10);
            binaryTree.Root.Left.Right.Right = new Node(14);
            Console.WriteLine("Level order traversal is ");
            PrintLevelOrder(binaryTree);
            PrintLevelByLevel(binaryTree);
            Console.ReadKey();
        }

        static void PrintLevelOrder(BinaryTree binaryTree)
        {
            if (binaryTree?.Root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(binaryTree.Root);

                while (queue.Count > 0)
                {
                    Node temp = queue.Dequeue();
                    Console.Write(temp.Data + " ");

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
            }

            Console.WriteLine();
        }

        static void PrintLevelByLevel(BinaryTree binaryTree)
        {
            if (binaryTree?.Root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(binaryTree.Root);

                while (queue.Count > 0)
                {
                    int level = queue.Count;

                    while (level > 0)
                    {
                        Node temp = queue.Dequeue();
                        Console.Write(temp.Data + " ");
                        level--;

                        if (temp.Left != null)
                            queue.Enqueue(temp.Left);

                        if (temp.Right != null)
                            queue.Enqueue(temp.Right);
                    }

                    Console.WriteLine();
                }
            }
        }
    }

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
}
