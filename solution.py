Here is a Python console application that calculates the diameter of a binary tree:

```python
class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

def height(node):
    if node is None:
        return 0
    return 1 + max(height(node.left), height(node.right))

def diameter(root):
    if root is None:
        return 0

    lheight = height(root.left)
    rheight = height(root.right)

    ldiameter = diameter(root.left)
    rdiameter = diameter(root.right)

    return max(lheight + rheight + 1, max(ldiameter, rdiameter))

def main():
    root = Node(1)
    root.left = Node(2)
    root.right = Node(3)
    root.left.left = Node(4)
    root.left.right = Node(5)

    print("Diameter of the binary tree is %d" % (diameter(root)))

if __name__ == "__main__":
    main()
```

This Python console application first defines a `Node` class for the binary tree nodes. Then it defines a `height` function to calculate the height of a binary tree and a `diameter` function to calculate the diameter of a binary tree. The `main` function creates a binary tree and prints its diameter.