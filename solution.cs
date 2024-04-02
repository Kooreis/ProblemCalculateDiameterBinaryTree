Here is a C# console application that calculates the diameter of a binary tree:

```C#
using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    public Node root;

    int diameter(Node tree)
    {
        if (tree == null)
            return 0;

        int lheight = height(tree.left);
        int rheight = height(tree.right);

        int ldiameter = diameter(tree.left);
        int rdiameter = diameter(tree.right);

        return Math.Max(lheight + rheight + 1,
                        Math.Max(ldiameter, rdiameter));
    }

    int diameter()
    {
        return diameter(root);
    }

    static int height(Node node)
    {
        if (node == null)
            return 0;

        return (1 + Math.Max(height(node.left), height(node.right)));
    }

    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        Console.WriteLine("The diameter of the binary tree is : "
                          + tree.diameter());
    }
}
```

This program creates a binary tree and calculates its diameter. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root. The length of a path between two nodes is represented by the number of edges between them.