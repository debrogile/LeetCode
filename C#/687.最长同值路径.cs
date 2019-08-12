/*
 * @lc app=leetcode.cn id=687 lang=csharp
 *
 * [687] 最长同值路径
 *
 * https://leetcode-cn.com/problems/longest-univalue-path/description/
 *
 * algorithms
 * Easy (34.68%)
 * Likes:    125
 * Dislikes: 0
 * Total Accepted:    4.9K
 * Total Submissions: 13.6K
 * Testcase Example:  '[5,4,5,1,1,5]'
 *
 * 给定一个二叉树，找到最长的路径，这个路径中的每个节点具有相同值。 这条路径可以经过也可以不经过根节点。
 * 
 * 注意：两个节点之间的路径长度由它们之间的边数表示。
 * 
 * 示例 1:
 * 
 * 输入:
 * 
 * 
 * ⁠             5
 * ⁠            / \
 * ⁠           4   5
 * ⁠          / \   \
 * ⁠         1   1   5
 * 
 * 
 * 输出:
 * 
 * 
 * 2
 * 
 * 
 * 示例 2:
 * 
 * 输入:
 * 
 * 
 * ⁠             1
 * ⁠            / \
 * ⁠           4   5
 * ⁠          / \   \
 * ⁠         4   4   5
 * 
 * 
 * 输出:
 * 
 * 
 * 2
 * 
 * 
 * 注意: 给定的二叉树不超过10000个结点。 树的高度不超过1000。
 * 
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System;

public class Solution
{
    public int LongestUnivaluePath(TreeNode root)
    {
        int max = 0;

        int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Depth(node.left);
            if (node.left != null && node.left.val == node.val)
            {
                left++;
            }
            else
            {
                left = 0;
            }

            int right = Depth(node.right);
            if (node.right != null && node.right.val == node.val)
            {
                right++;
            }
            else
            {
                right = 0;
            }

            max = Math.Max(max, left + right);

            return Math.Max(left, right);
        }

        Depth(root);

        return max;
    }
}
