/*
 * @lc app=leetcode.cn id=590 lang=csharp
 *
 * [590] N叉树的后序遍历
 *
 * https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/description/
 *
 * algorithms
 * Easy (67.88%)
 * Likes:    27
 * Dislikes: 0
 * Total Accepted:    7.3K
 * Total Submissions: 10.6K
 * Testcase Example:  '{"$id":"1","children":[{"$id":"2","children":[{"$id":"5","children":[],"val":5},{"$id":"6","children":[],"val":6}],"val":3},{"$id":"3","children":[],"val":2},{"$id":"4","children":[],"val":4}],"val":1}'
 *
 * 给定一个 N 叉树，返回其节点值的后序遍历。
 * 
 * 例如，给定一个 3叉树 :
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 返回其后序遍历: [5,6,3,2,4,1].
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
public class Solution
{
    public IList<int> Postorder(Node root)
    {
        var list = new List<int>();

        void InternalPreOrder(Node node)
        {
            if (node.children != null)
            {
                foreach (var child in node.children)
                {
                    InternalPreOrder(child);
                }
            }

            list.Add(node.val);
        }

        if (root != null)
        {
            InternalPreOrder(root);
        }

        return list;
    }
}
