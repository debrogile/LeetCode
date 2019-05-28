/*
 * @lc app=leetcode.cn id=404 lang=csharp
 *
 * [404] 左叶子之和
 *
 * https://leetcode-cn.com/problems/sum-of-left-leaves/description/
 *
 * algorithms
 * Easy (49.70%)
 * Likes:    76
 * Dislikes: 0
 * Total Accepted:    6.8K
 * Total Submissions: 13.7K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * 计算给定二叉树的所有左叶子之和。
 * 
 * 示例：
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 在这个二叉树中，有两个左叶子，分别是 9 和 15，所以返回 24
 * 
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
    public int SumOfLeftLeaves(TreeNode root)
    {
        int sum = 0;
        if (root != null)
        {
            DFS(root, false, ref sum);
        }

        return sum;
    }

    private void DFS(TreeNode node, bool isLeft, ref int sum)
    {
        if (node.left == null && node.right == null)
        {
            if (isLeft)
            {
                sum += node.val;
            }

            return;
        }

        if (node.left != null)
        {
            DFS(node.left, true, ref sum);
        }

        if (node.right != null)
        {
            DFS(node.right, false, ref sum);
        }
    }
}
