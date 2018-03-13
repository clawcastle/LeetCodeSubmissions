namespace LeetCode.SymmetricTree
{

    //https://leetcode.com/problems/symmetric-tree/description/

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return IsSymmetricRecursively(root.left, root.right);
        }

        private bool IsSymmetricRecursively(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return (left == null && right == null);
            }

            return (left.val == right.val && IsSymmetricRecursively(left.left, right.right) && IsSymmetricRecursively(left.right, right.left));
        }
    }
}
