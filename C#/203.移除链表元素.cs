/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
 *
 * https://leetcode-cn.com/problems/remove-linked-list-elements/description/
 * 
 * 删除链表中等于给定值 val 的所有节点。
 * 
 * 示例:
 * 
 * 输入: 1->2->6->3->4->5->6, val = 6
 * 输出: 1->2->3->4->5
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode p1 = null;

        var p2 = head;
        while (p2 != null)
        {
            if (p2.val != val)
            {
                p1 = p2;
            }

            p2 = p2.next;

            if (p1 == null)
            {
                head = p2;
            }
            else
            {
                p1.next = p2;
            }
        }

        return head;
    }
}
