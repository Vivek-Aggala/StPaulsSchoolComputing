using System;

namespace binary_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            tree binaryTree = new tree();

            binaryTree.Add(4);
            binaryTree.Add(43);
            binaryTree.Add(43);
            binaryTree.Add(54);
            binaryTree.Add(90);
            binaryTree.Add(32);
            binaryTree.Add(42);
            Console.WriteLine("Preorder traversal " +
                       "of binary tree is ");
            binaryTree.Preorder();

            Console.WriteLine("\nInorder traversal " +
                                "of binary tree is ");
            binaryTree.printInorder();

            Console.WriteLine("\nPostorder traversal " +
                                  "of binary tree is ");
            binaryTree.Postorder();
        }
    }
}
