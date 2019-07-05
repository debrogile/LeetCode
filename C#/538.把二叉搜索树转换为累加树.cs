using System.Runtime.InteropServices.WindowsRuntime;
/*
 * @lc app=leetcode.cn id=538 lang=csharp
 *
 * [538] 把二叉搜索树转换为累加树
 *
 * https://leetcode-cn.com/problems/convert-bst-to-greater-tree/description/
 *
 * algorithms
 * Easy (52.79%)
 * Likes:    115
 * Dislikes: 0
 * Total Accepted:    5.1K
 * Total Submissions: 9.4K
 * Testcase Example:  '[5,2,13]'
 *
 * 给定一个二叉搜索树（Binary Search Tree），把它转换成为累加树（Greater
 * Tree)，使得每个节点的值是原来的节点值加上所有大于它的节点值之和。
 * 
 * 例如：
 * 
 * 
 * 输入: 二叉搜索树:
 * ⁠             5
 * ⁠           /   \
 * ⁠          2     13
 * 
 * 输出: 转换为累加树:
 * ⁠            18
 * ⁠           /   \
 * ⁠         20     13
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
public class Solution
{
    public TreeNode ConvertBST(TreeNode root)
    {
        TreeNode prev = null;

        void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.right);
            if (prev != null)
            {
                node.val += prev.val;
            }
            prev = node;
            InOrder(node.left);
        }

        InOrder(root);
        return root;
    }
}
