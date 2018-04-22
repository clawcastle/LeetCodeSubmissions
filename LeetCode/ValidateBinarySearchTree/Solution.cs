using System;

namespace LeetCode.ValidateBinarySearchTree
{
    //https://leetcode.com/problems/validate-binary-search-tree/description/
        public class Solution
        {
            public bool IsValidBST(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }
                return ValidateRecursively(root, Int64.MinValue, Int64.MaxValue);
            }

            public bool ValidateRecursively(TreeNode node, long minValue, long maxValue)
            {
                if (node == null)
                {
                    return true;
                }
                if (node.val >= maxValue || node.val <= minValue)
                {
                    return false;
                }
                return ValidateRecursively(node.left, minValue, node.val) && ValidateRecursively(node.right, node.val, maxValue);
            }
        }
    }

