/*
 * @lc app=leetcode.cn id=111 lang=csharp
 *
 * [111] 二叉树的最小深度
 *
 * https://leetcode-cn.com/problems/minimum-depth-of-binary-tree/description/
 * 
 * 给定一个二叉树， 找出其最小深度。
 *
 * 最小深度是从根节点到最近叶子节点的最短路径上的节点数量。
 * 
 * 说明: 叶子节点是指没有子节点的节点。
 *
 * 示例:
 *
 * 给定二叉树[3, 9, 20, null, null, 15, 7],
 *
 *    3 
 *   / \
 *  9  20 
 *    / \
 *  15  7
 * 返回它的最小深度 2.
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
