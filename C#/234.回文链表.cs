/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
 * 
 * https://leetcode-cn.com/problems/palindrome-linked-list/description/
 *
 * 请判断一个链表是否为回文链表。
 * 
 * 示例 1:
 * 
 * 输入: 1->2
 * 输出: false
 * 示例 2:
 * 
 * 输入: 1->2->2->1
 * 输出: true
 * 进阶：
 * 你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
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
    public bool IsPalindrome(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next == null ? fast.next : fast.next.next;
        }

        ListNode prev = null;
        while (slow != null)
        {
            var temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }

        while (head != null && prev != null)
        {
            if (head.val != prev.val)
            {
                return false;
            }

            head = head.next;
            prev = prev.next;
        }

        return true;
    }
}
