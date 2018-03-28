using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SameTree
{
    //https://leetcode.com/problems/same-tree/description/
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return CompareNodesRecursively(p, q);
        }

        public bool CompareNodesRecursively(TreeNode node1, TreeNode node2)
        {
            if (node1 == null || node2 == null)
            {
                return node1 == null && node2 == null;
            }

            return node1.val == node2.val && CompareNodesRecursively(node1.left, node2.left) && CompareNodesRecursively(node1.right, node2.right);
        }
    }
}
