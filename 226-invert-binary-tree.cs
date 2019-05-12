public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return root;
        }
        var temp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);
        return root;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x)
    {
        val = x;
    }
}