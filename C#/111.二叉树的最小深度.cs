/*
 * @lc app=leetcode.cn id=111 lang=csharp
 *
 * [111] 二叉树的最小深度
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
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else if (root.left == null)
        {
            return MinDepth(root.right) + 1;
        }
        else if (root.right == null)
        {
            return MinDepth(root.left) + 1;
        }
        else
        {
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
