namespace NeetCode.Easy.DFS
{
    public class Maximum_Depth_Binary_Tree_104
    {
        public int MaxDepth(TreeNode root)
        {
            int x, y = 0;

            if (root == null)
            {
                return 0;
            }
            x = MaxDepth(root.left);
            y = MaxDepth(root.right);

            if (x > y)
            {
                return x + 1;
            }
            return y + 1;
        }
    }
}
