using System.Xml.Linq;
/*
 * @lc app=leetcode.cn id=589 lang=csharp
 *
 * [589] N叉树的前序遍历
 *
 * https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/description/
 *
 * algorithms
 * Easy (67.81%)
 * Likes:    49
 * Dislikes: 0
 * Total Accepted:    8.3K
 * Total Submissions: 12.1K
 * Testcase Example:  '{"$id":"1","children":[{"$id":"2","children":[{"$id":"5","children":[],"val":5},{"$id":"6","children":[],"val":6}],"val":3},{"$id":"3","children":[],"val":2},{"$id":"4","children":[],"val":4}],"val":1}'
 *
 * 给定一个 N 叉树，返回其节点值的前序遍历。
 * 
 * 例如，给定一个 3叉树 :
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 返回其前序遍历: [1,3,5,6,2,4]。
 * 
 * 
 * 
 * 说明: 递归法很简单，你可以使用迭代法完成此题吗?
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
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();

        void InternalPreOrder(Node node)
        {
            list.Add(node.val);
            if (node.children != null)
            {
                foreach (var child in node.children)
                {
                    InternalPreOrder(child);
                }
            }
        }

        if (root != null)
        {
            InternalPreOrder(root);
        }

        return list;
    }
}
