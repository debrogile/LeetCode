/*
 * @lc app=leetcode.cn id=563 lang=csharp
 *
 * [563] 二叉树的坡度
 *
 * https://leetcode-cn.com/problems/binary-tree-tilt/description/
 *
 * algorithms
 * Easy (47.94%)
 * Likes:    34
 * Dislikes: 0
 * Total Accepted:    4.1K
 * Total Submissions: 8.5K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个二叉树，计算整个树的坡度。
 * 
 * 一个树的节点的坡度定义即为，该节点左子树的结点之和和右子树结点之和的差的绝对值。空结点的的坡度是0。
 * 
 * 整个树的坡度就是其所有节点的坡度之和。
 * 
 * 示例:
 * 
 * 
 * 输入: 
 * ⁠        1
 * ⁠      /   \
 * ⁠     2     3
 * 输出: 1
 * 解释: 
 * 结点的坡度 2 : 0
 * 结点的坡度 3 : 0
 * 结点的坡度 1 : |2-3| = 1
 * 树的坡度 : 0 + 0 + 1 = 1
 * 
 * 
 * 注意:
 * 
 * 
 * 任何子树的结点的和不会超过32位整数的范围。
 * 坡度的值不会超过32位整数的范围。
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

public class Solution
{
    public int FindTilt(TreeNode root)
    {
        Tilt(root, out int tilt, out int sum);

        return tilt;
    }

    private void Tilt(TreeNode root, out int tilt, out int sum)
    {
        if (root == null)
        {
            tilt = 0;
            sum = 0;
        }
        else
        {
            Tilt(root.left, out int lt, out int ls);
            Tilt(root.right, out int rt, out int rs);

            tilt = lt + rt + Math.Abs(ls - rs);
            sum = ls + rs + root.val;
        }
    }
}
