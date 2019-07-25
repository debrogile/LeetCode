/*
 * @lc app=leetcode.cn id=653 lang=csharp
 *
 * [653] 两数之和 IV - 输入 BST
 *
 * https://leetcode-cn.com/problems/two-sum-iv-input-is-a-bst/description/
 *
 * algorithms
 * Easy (51.01%)
 * Likes:    80
 * Dislikes: 0
 * Total Accepted:    5.8K
 * Total Submissions: 11.1K
 * Testcase Example:  '[5,3,6,2,4,null,7]\n9'
 *
 * 给定一个二叉搜索树和一个目标结果，如果 BST 中存在两个元素且它们的和等于给定的目标结果，则返回 true。
 * 
 * 案例 1:
 * 
 * 
 * 输入: 
 * ⁠   5
 * ⁠  / \
 * ⁠ 3   6
 * ⁠/ \   \
 * 2   4   7
 * 
 * Target = 9
 * 
 * 输出: True
 * 
 * 
 * 
 * 
 * 案例 2:
 * 
 * 
 * 输入: 
 * ⁠   5
 * ⁠  / \
 * ⁠ 3   6
 * ⁠/ \   \
 * 2   4   7
 * 
 * Target = 28
 * 
 * 输出: False
 * 
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
using System.Collections.Generic;

public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        var list = new List<int>();

        void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left);
            list.Add(node.val);
            InOrder(node.right);
        }

        InOrder(root);

        int i = 0;
        int j = list.Count - 1;
        while (i < j)
        {
            int sum = list[i] + list[j];
            if (sum == k)
            {
                return true;
            }
            else if (sum > k)
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return false;
    }
}
