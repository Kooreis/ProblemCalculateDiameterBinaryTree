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
}