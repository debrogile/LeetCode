/*
 * @lc app=leetcode.cn id=232 lang=csharp
 *
 * [232] 用栈实现队列
 * 
 * https://leetcode-cn.com/problems/implement-queue-using-stacks/description/
 *
 * 使用栈实现队列的下列操作：
 * 
 * push(x) -- 将一个元素放入队列的尾部。
 * pop() -- 从队列首部移除元素。
 * peek() -- 返回队列首部的元素。
 * empty() -- 返回队列是否为空。
 * 示例:
 * 
 * MyQueue queue = new MyQueue();
 * 
 * queue.push(1);
 * queue.push(2);  
 * queue.peek();  // 返回 1
 * queue.pop();   // 返回 1
 * queue.empty(); // 返回 false
 * 说明:
 * 
 * 你只能使用标准的栈操作 -- 也就是只有 push to top, peek/pop from top, size, 和 is empty 操作是合法的。
 * 你所使用的语言也许不支持栈。你可以使用 list 或者 deque（双端队列）来模拟一个栈，只要是标准的栈操作即可。
 * 假设所有操作都是有效的 （例如，一个空的队列不会调用 pop 或者 peek 操作）。
 */
/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
using System.Collections.Generic;

public class MyQueue
{
    // 输入栈
    private Stack<int> a = new Stack<int>();
    // 输出栈
    private Stack<int> b = new Stack<int>();

    /** Initialize your data structure here. */
    public MyQueue()
    {

    }

    /** Push element x to the back of queue. */
    public void Push(int x)
    {
        a.Push(x);
    }

    /** Removes the element from in front of queue and returns that element. */
    public int Pop()
    {
        if (b.Count == 0)
        {
            while (a.Count > 0)
            {
                b.Push(a.Pop());
            }
        }

        return b.Pop();
    }

    /** Get the front element. */
    public int Peek()
    {
        if (b.Count == 0)
        {
            while (a.Count > 0)
            {
                b.Push(a.Pop());
            }
        }
        
        return b.Peek();
    }

    /** Returns whether the queue is empty. */
    public bool Empty()
    {
        return a.Count == 0 && b.Count == 0;
    }
}
