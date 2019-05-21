public class Solution<T>
{
    public TreeNode<T> TreeToArrayAndBackAgain(TreeNode<T> root, int size)
    {
        if (root == null)
        {
            return null;
        }
        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(root);
        var arr = TreeToArray(queue, size);
        var tree = ArrayToTree(arr, 0);
        return tree;
    }

    private T[] TreeToArray(Queue<TreeNode<T>> queue, int size)
    {
        int iter = 0;
        T[] result = new T[size];
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            result[iter++] = current.Value;
            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }
            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
        return result;
    }

    private TreeNode<T> ArrayToTree<T>(T[] arr, int index)
    {
        if (index >= arr.Length)
        {
            return null;
        }
        TreeNode<T> node = new TreeNode<T>(arr[index]);
        node.Left = ArrayToTree<T>(arr, 2 * index + 1);
        node.Right = ArrayToTree<T>(arr, 2 * index + 2);
        return node;
    }
}

public class TreeNode<T>
{
    public TreeNode(T value)
    {
        Value = value;
    }

    public T Value { get; set; }

    public TreeNode<T> Left { get; set; }

    public TreeNode<T> Right { get; set; }
}