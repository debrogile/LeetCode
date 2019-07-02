/*
 * @lc app=leetcode.cn id=530 lang=csharp
 *
 * [530] 二叉搜索树的最小绝对差
 *
 * https://leetcode-cn.com/problems/minimum-absolute-difference-in-bst/description/
 *
 * algorithms
 * Easy (53.14%)
 * Likes:    61
 * Dislikes: 0
 * Total Accepted:    4.4K
 * Total Submissions: 8.2K
 * Testcase Example:  '[1,null,3,2]'
 *
 * 给定一个所有节点为非负值的二叉搜索树，求树中任意两节点的差的绝对值的最小值。
 * 
 * 示例 :
 * 
 * 
 * 输入:
 * 
 * ⁠  1
 * ⁠   \
 * ⁠    3
 * ⁠   /
 * ⁠  2
 * 
 * 输出:
 * 1
 * 
 * 解释:
 * 最小绝对差为1，其中 2 和 1 的差的绝对值为 1（或者 2 和 3）。
 * 
 * 
 * 注意: 树中至少有2个节点。
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
    public int GetMinimumDifference(TreeNode root)
    {
        int min = int.MaxValue;
        TreeNode prev = null;

        void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left);
            if (prev != null)
            {
                min = Math.Min(min, node.val - prev.val);
            }
            prev = node;
            InOrder(node.right);
        }

        InOrder(root);

        return min;
    }
}
