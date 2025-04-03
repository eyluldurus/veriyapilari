// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    public void PreorderTraversal(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");  // kok dugum
        PreorderTraversal(node.Left);   // sol alt dugum
        PreorderTraversal(node.Right);  // sag alt dugum
    }

    public void InorderTraversal(Node node)
    {
        if (node == null) return;

        InorderTraversal(node.Left);   
        Console.Write(node.Data + " "); 
        InorderTraversal(node.Right);  
    }

    public void PostorderTraversal(Node node)
    {
        if (node == null) return;

        PostorderTraversal(node.Left);   
        PostorderTraversal(node.Right);  
        Console.Write(node.Data + " ");  
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Right.Left = new Node(6);
        tree.Root.Right.Right = new Node(7);

        Console.WriteLine("Preorder Traversal:");
        tree.PreorderTraversal(tree.Root);
        Console.WriteLine();

        Console.WriteLine("Inorder Traversal:");
        tree.InorderTraversal(tree.Root);
        Console.WriteLine();

        Console.WriteLine("Postorder Traversal:");
        tree.PostorderTraversal(tree.Root);
        Console.WriteLine();
    }
}
