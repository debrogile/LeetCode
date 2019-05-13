/*
 * @lc app=leetcode.cn id=257 lang=csharp
 *
 * [257] 二叉树的所有路径
 * 
 * https://leetcode-cn.com/problems/binary-tree-paths/description/
 *
 * 给定一个二叉树，返回所有从根节点到叶子节点的路径。
 * 
 * 说明: 叶子节点是指没有子节点的节点。
 * 
 * 示例:
 * 
 * 输入:
 * 
 *    1
 *  /   \
 * 2     3
 *  \
 *   5
 * 
 * 输出: ["1->2->5", "1->3"]
 * 
 * 解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
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
using System.Collections.Generic;

public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var list = new List<string>();

        if (root != null)
        {
            var ll = BinaryTreePaths(root.left);
            foreach (var l in ll)
            {
                list.Add(string.Format("{0}->{1}", root.val, l));
            }

            var rl = BinaryTreePaths(root.right);
            foreach (var r in rl)
            {
                list.Add(string.Format("{0}->{1}", root.val, r));
            }

            if (list.Count == 0)
            {
                list.Add(root.val.ToString());
            }
        }

        return list;
    }
}
