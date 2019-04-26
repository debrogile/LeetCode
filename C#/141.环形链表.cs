/*
 * @lc app=leetcode.cn id=141 lang=csharp
 *
 * [141] 环形链表
 *
 * 给定一个链表，判断链表中是否有环。
 *
 * 为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。
 *
 * 示例 1：
 *
 * 输入：head = [3,2,0,-4], pos = 1
 * 输出：true
 * 解释：链表中有一个环，其尾部连接到第二个节点。
 * 
 * 示例 2：
 * 
 * 输入：head = [1,2], pos = 0
 * 输出：true
 * 解释：链表中有一个环，其尾部连接到第一个节点。
 *
 * 示例 3：
 *
 * 输入：head = [1], pos = -1
 * 输出：false
 * 解释：链表中没有环。
 *
 * 进阶：
 *
 * 你能用 O(1)（即，常量）内存解决此问题吗？
 *
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    /// <summary>
    /// 快慢指针，慢指针一次一步，快指针一次两步
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool HasCycle(ListNode head)
    {
        var low = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            low = low.next;
            fast = fast.next.next;

            if (low == fast)
            {
                return true;
            }
        }

        return false;
    }
}
