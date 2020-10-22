using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(55);
            //linkedList.Add(66);
            //linkedList.Add(77);
            //linkedList.Display();

            //LinkedListStack listStack = new LinkedListStack();
            // listStack.push(56);
            // listStack.push(66);
            // listStack.push(26);
            //listStack.Display();
            //listStack.peek();

            LinkedListQueue listQueue = new LinkedListQueue();
            listQueue.Enqueue(10);
            listQueue.Enqueue(20);
            listQueue.Enqueue(30);
            listQueue.Display();
        }
    }
}
