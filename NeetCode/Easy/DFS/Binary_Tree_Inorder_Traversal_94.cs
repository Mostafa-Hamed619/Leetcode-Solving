namespace NeetCode.Easy.DFS
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


    public class Binary_Tree_Inorder_Traversal_94
    {
        private IList<int> Result = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return Result;
            }
            InorderTraversal(root.left);
            Result.Add(root.val);
            InorderTraversal(root.right);
            return Result;
        }
    }
}
