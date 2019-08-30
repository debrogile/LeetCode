/*
 * @lc app=leetcode.cn id=706 lang=csharp
 *
 * [706] 设计哈希映射
 *
 * https://leetcode-cn.com/problems/design-hashmap/description/
 *
 * algorithms
 * Easy (55.41%)
 * Likes:    19
 * Dislikes: 0
 * Total Accepted:    4.9K
 * Total Submissions: 8.8K
 * Testcase Example:  '["MyHashMap","put","put","get","get","put","get", "remove", "get"]\n' +
  '[[],[1,1],[2,2],[1],[3],[2,1],[2],[2],[2]]'
 *
 * 不使用任何内建的哈希表库设计一个哈希映射
 * 
 * 具体地说，你的设计应该包含以下的功能
 * 
 * 
 * put(key, value)：向哈希映射中插入(键,值)的数值对。如果键对应的值已经存在，更新这个值。
 * get(key)：返回给定的键所对应的值，如果映射中不包含这个键，返回-1。
 * remove(key)：如果映射中存在这个键，删除这个数值对。
 * 
 * 
 * 
 * 示例：
 * 
 * 
 * MyHashMap hashMap = new MyHashMap();
 * hashMap.put(1, 1);          
 * hashMap.put(2, 2);         
 * hashMap.get(1);            // 返回 1
 * hashMap.get(3);            // 返回 -1 (未找到)
 * hashMap.put(2, 1);         // 更新已有的值
 * hashMap.get(2);            // 返回 1 
 * hashMap.remove(2);         // 删除键为2的数据
 * hashMap.get(2);            // 返回 -1 (未找到) 
 * 
 * 
 * 
 * 注意：
 * 
 * 
 * 所有的值都在 [1, 1000000]的范围内。
 * 操作的总数目在[1, 10000]范围内。
 * 不要使用内建的哈希库。
 * 
 * 
 */
public class MyHashMap
{
    private const int L = 1024;
    private Node[] nodes;

    /** Initialize your data structure here. */
    public MyHashMap()
    {
        nodes = new Node[L];
        for (int i = 0; i < L; i++)
        {
            nodes[i] = new Node { Key = -1 };
        }
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
        int hash = key % L;
        var node = nodes[hash];
        while (node.Next != null)
        {
            if (node.Next.Key == key)
            {
                node.Next.Value = value;
                return;
            }

            node = node.Next;
        }

        node.Next = new Node { Key = key, Value = value };
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        int hash = key % L;
        var node = nodes[hash].Next;
        while (node != null)
        {
            if (node.Key == key)
            {
                return node.Value;
            }

            node = node.Next;
        }

        return -1;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        int hash = key % L;
        var prev = nodes[hash];
        var node = prev.Next;
        while (node != null)
        {
            if (node.Key == key)
            {
                prev.Next = node.Next;
                return;
            }

            prev = node;
            node = node.Next;
        }
    }
}

public class Node
{
    public int Key { get; set; }
    public int Value { get; set; }
    public Node Next { get; set; }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
