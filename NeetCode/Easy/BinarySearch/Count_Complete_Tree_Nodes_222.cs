namespace NeetCode.Easy.BinarySearch
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    public class Count_Complete_Tree_Nodes_222
    {
        public int CountNodes(TreeNode root)
        {
            int x = 0;
            int y = 0;

            if (root != null)
            {
                x = CountNodes(root.left);
                y = CountNodes(root.right);
                return x + y + 1;
            }
            return 0;
        }
    }
}
