using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
            {
                node.next = this.top;

            }
            this.top = node;
            Console.WriteLine("{0} is pushed", value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        internal void peek()
        {
            if (this.top == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine(top.data);

        }
    }
}
