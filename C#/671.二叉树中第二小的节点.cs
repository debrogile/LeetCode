using System.Linq;
/*
 * @lc app=leetcode.cn id=671 lang=csharp
 *
 * [671] 二叉树中第二小的节点
 *
 * https://leetcode-cn.com/problems/second-minimum-node-in-a-binary-tree/description/
 *
 * algorithms
 * Easy (44.44%)
 * Likes:    43
 * Dislikes: 0
 * Total Accepted:    3.9K
 * Total Submissions: 8.8K
 * Testcase Example:  '[2,2,5,null,null,5,7]'
 *
 * 给定一个非空特殊的二叉树，每个节点都是正数，并且每个节点的子节点数量只能为 2 或
 * 0。如果一个节点有两个子节点的话，那么这个节点的值不大于它的子节点的值。 
 * 
 * 给出这样的一个二叉树，你需要输出所有节点中的第二小的值。如果第二小的值不存在的话，输出 -1 。
 * 
 * 示例 1:
 * 
 * 
 * 输入: 
 * ⁠   2
 * ⁠  / \
 * ⁠ 2   5
 * ⁠    / \
 * ⁠   5   7
 * 
 * 输出: 5
 * 说明: 最小的值是 2 ，第二小的值是 5 。
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: 
 * ⁠   2
 * ⁠  / \
 * ⁠ 2   2
 * 
 * 输出: -1
 * 说明: 最小的值是 2, 但是不存在第二小的值。
 * 
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
using System.Collections.Generic;

public class Solution
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        int min = -1;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.left != null)
            {
                if (node.left.val == root.val)
                {
                    queue.Enqueue(node.left);
                }
                else if (min == -1)
                {
                    min = node.left.val;
                }
                else
                {
                    min = Math.Min(min, node.left.val);
                }

                if (node.right.val == root.val)
                {
                    queue.Enqueue(node.right);
                }
                else if (min == -1)
                {
                    min = node.right.val;
                }
                else
                {
                    min = Math.Min(min, node.right.val);
                }
            }
        }

        return min;
    }
}
