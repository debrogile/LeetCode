/*
 * @lc app=leetcode.cn id=705 lang=csharp
 *
 * [705] 设计哈希集合
 *
 * https://leetcode-cn.com/problems/design-hashset/description/
 *
 * algorithms
 * Easy (55.26%)
 * Likes:    21
 * Dislikes: 0
 * Total Accepted:    5.7K
 * Total Submissions: 10.3K
 * Testcase Example:  '["MyHashSet","add","add","contains","contains","add","contains","remove","contains"]\n' +
  '[[],[1],[2],[1],[3],[2],[2],[2],[2]]'
 *
 * 不使用任何内建的哈希表库设计一个哈希集合
 * 
 * 具体地说，你的设计应该包含以下的功能
 * 
 * 
 * add(value)：向哈希集合中插入一个值。
 * contains(value) ：返回哈希集合中是否存在这个值。
 * remove(value)：将给定值从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。
 * 
 * 
 * 
 * 示例:
 * 
 * MyHashSet hashSet = new MyHashSet();
 * hashSet.add(1);         
 * hashSet.add(2);         
 * hashSet.contains(1);    // 返回 true
 * hashSet.contains(3);    // 返回 false (未找到)
 * hashSet.add(2);          
 * hashSet.contains(2);    // 返回 true
 * hashSet.remove(2);          
 * hashSet.contains(2);    // 返回  false (已经被删除)
 * 
 * 
 * 
 * 注意：
 * 
 * 
 * 所有的值都在 [1, 1000000]的范围内。
 * 操作的总数目在[1, 10000]范围内。
 * 不要使用内建的哈希集合库。
 * 
 * 
 */
using System.Collections.Generic;

public class MyHashSet
{
    private const int L = 1024;
    private Node[] nodes;

    /** Initialize your data structure here. */
    public MyHashSet()
    {
        nodes = new Node[L];
        for (int i = 0; i < L; i++)
        {
            nodes[i] = new Node { Value = -1 };
        }
    }

    public void Add(int key)
    {
        int hash = key % L;
        var node = nodes[hash];
        while (node.Next != null)
        {
            if (node.Next.Value == key)
            {
                return;
            }

            node = node.Next;
        }

        node.Next = new Node { Value = key };
    }

    public void Remove(int key)
    {
        int hash = key % L;
        var prev = nodes[hash];
        var node = prev.Next;
        while (node != null)
        {
            if (node.Value == key)
            {
                prev.Next = node.Next;
                return;
            }

            prev = node;
            node = node.Next;
        }
    }

    /** Returns true if this set contains the specified element */
    public bool Contains(int key)
    {
        int hash = key % L;
        var node = nodes[hash].Next;
        while (node != null)
        {
            if (node.Value == key)
            {
                return true;
            }

            node = node.Next;
        }

        return false;
    }
}

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
