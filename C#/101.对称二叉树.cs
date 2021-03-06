/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
 *
 * https://leetcode-cn.com/problems/symmetric-tree/description/
 *
 * algorithms
 * Easy (45.94%)
 * Total Accepted:    28.9K
 * Total Submissions: 62.9K
 * Testcase Example:  '[1,2,2,3,4,4,3]'
 *
 * 给定一个二叉树，检查它是否是镜像对称的。
 * 
 * 例如，二叉树 [1,2,2,3,4,4,3] 是对称的。
 * 
 * ⁠   1
 * ⁠  / \
 * ⁠ 2   2
 * ⁠/ \ / \
 * 3  4 4  3
 * 
 * 
 * 但是下面这个 [1,2,2,null,3,null,3] 则不是镜像对称的:
 * 
 * ⁠   1
 * ⁠  / \
 * ⁠ 2   2
 * ⁠  \   \
 * ⁠  3    3
 * 
 * 
 * 说明:
 * 
 * 如果你可以运用递归和迭代两种方法解决这个问题，会很加分。
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
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        else
        {
            return IsSymmetric(root.left, root.right);
        }
    }

    private bool IsSymmetric(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        else if (p == null && q != null)
        {
            return false;
        }
        else if (p != null && q == null)
        {
            return false;
        }
        else if (p.val != q.val)
        {
            return false;
        }
        else
        {
            return IsSymmetric(p.left, q.right) && IsSymmetric(p.right, q.left);
        }
    }
}
