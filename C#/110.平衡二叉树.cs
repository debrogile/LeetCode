/*
 * @lc app=leetcode.cn id=110 lang=csharp
 *
 * [110] 平衡二叉树
 *
 * https://leetcode-cn.com/problems/balanced-binary-tree/description/
 *
 * algorithms
 * Easy (47.04%)
 * Total Accepted:    15K
 * Total Submissions: 31.8K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * 给定一个二叉树，判断它是否是高度平衡的二叉树。
 * 
 * 本题中，一棵高度平衡二叉树定义为：
 * 
 * 
 * 一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。
 * 
 * 
 * 示例 1:
 * 
 * 给定二叉树 [3,9,20,null,null,15,7]
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 返回 true 。
 * 
 * 示例 2:
 * 
 * 给定二叉树 [1,2,2,3,3,null,null,4,4]
 * 
 * ⁠      1
 * ⁠     / \
 * ⁠    2   2
 * ⁠   / \
 * ⁠  3   3
 * ⁠ / \
 * ⁠4   4
 * 
 * 
 * 返回 false 。
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
    public bool IsBalanced(TreeNode root)
    {
        if (CheckDepth(root) == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private int CheckDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = CheckDepth(root.left);
        if (left == -1)
        {
            return -1;
        }

        int right = CheckDepth(root.right);
        if (right == -1)
        {
            return -1;
        }

        int diff = Math.Abs(left - right);
        if (diff > 1)
        {
            return -1;
        }

        return Math.Max(left, right) + 1;
    }
}
