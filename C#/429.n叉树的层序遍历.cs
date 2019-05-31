/*
 * @lc app=leetcode.cn id=429 lang=csharp
 *
 * [429] N叉树的层序遍历
 *
 * https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/description/
 *
 * algorithms
 * Easy (61.19%)
 * Likes:    34
 * Dislikes: 0
 * Total Accepted:    6K
 * Total Submissions: 9.7K
 * Testcase Example:  '{"$id":"1","children":[{"$id":"2","children":[{"$id":"5","children":[],"val":5},{"$id":"6","children":[],"val":6}],"val":3},{"$id":"3","children":[],"val":2},{"$id":"4","children":[],"val":4}],"val":1}'
 *
 * 给定一个 N 叉树，返回其节点值的层序遍历。 (即从左到右，逐层遍历)。
 * 
 * 例如，给定一个 3叉树 :
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 返回其层序遍历:
 * 
 * [
 * ⁠    [1],
 * ⁠    [3,2,4],
 * ⁠    [5,6]
 * ]
 * 
 * 
 * 
 * 
 * 说明:
 * 
 * 
 * 树的深度不会超过 1000。
 * 树的节点总数不会超过 5000。
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
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {
        var list = new List<IList<int>>();

        if (root == null)
        {
            return list;
        }

        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level = new List<int>();
            for (int i = queue.Count; i > 0; i--)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                if (node.children != null)
                {
                    foreach (var child in node.children)
                    {
                        queue.Enqueue(child);
                    }
                }
            }

            list.Add(level);
        }

        return list;
    }
}
