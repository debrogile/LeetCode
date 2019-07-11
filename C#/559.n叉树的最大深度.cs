/*
 * @lc app=leetcode.cn id=559 lang=csharp
 *
 * [559] N叉树的最大深度
 *
 * https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/description/
 *
 * algorithms
 * Easy (65.87%)
 * Likes:    46
 * Dislikes: 0
 * Total Accepted:    8.1K
 * Total Submissions: 12.2K
 * Testcase Example:  '{"$id":"1","children":[{"$id":"2","children":[{"$id":"5","children":[],"val":5},{"$id":"6","children":[],"val":6}],"val":3},{"$id":"3","children":[],"val":2},{"$id":"4","children":[],"val":4}],"val":1}'
 *
 * 给定一个 N 叉树，找到其最大深度。
 * 
 * 最大深度是指从根节点到最远叶子节点的最长路径上的节点总数。
 * 
 * 例如，给定一个 3叉树 :
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 我们应返回其最大深度，3。
 * 
 * 说明:
 * 
 * 
 * 树的深度不会超过 1000。
 * 树的节点总不会超过 5000。
 * 
 */
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null)
        {
            return 0;
        }
        else if (root.children == null)
        {
            return 1;
        }
        else
        {
            int depth = 0;
            foreach (var child in root.children)
            {
                depth = Math.Max(depth, MaxDepth(child));
            }

            return depth + 1;
        }
    }
}
