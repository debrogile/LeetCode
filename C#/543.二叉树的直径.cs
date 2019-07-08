/*
 * @lc app=leetcode.cn id=543 lang=csharp
 *
 * [543] 二叉树的直径
 *
 * https://leetcode-cn.com/problems/diameter-of-binary-tree/description/
 *
 * algorithms
 * Easy (43.65%)
 * Likes:    90
 * Dislikes: 0
 * Total Accepted:    5.4K
 * Total Submissions: 12K
 * Testcase Example:  '[1,2,3,4,5]'
 *
 * 给定一棵二叉树，你需要计算它的直径长度。一棵二叉树的直径长度是任意两个结点路径长度中的最大值。这条路径可能穿过根结点。
 * 
 * 示例 :
 * 给定二叉树
 * 
 * 
 * ⁠         1
 * ⁠        / \
 * ⁠       2   3
 * ⁠      / \     
 * ⁠     4   5    
 * 
 * 
 * 返回 3, 它的长度是路径 [4,2,1,3] 或者 [5,2,1,3]。
 * 
 * 注意：两结点之间的路径长度是以它们之间边的数目表示。
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
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int diameter = 0;

        int DFS(TreeNode node)
        {
            int depth = 0;
            if (node != null)
            {
                int ld = DFS(node.left);
                int rd = DFS(node.right);
                depth = Math.Max(ld, rd) + 1;
                diameter = Math.Max(diameter, ld + rd);
            }

            return depth;
        }

        DFS(root);

        return diameter;
    }
}
