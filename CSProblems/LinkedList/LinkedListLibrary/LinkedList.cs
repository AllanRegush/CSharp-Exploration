using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListLibrary
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data, Node next)
            {
                Data = data;
                Next = next;
            }
        }

        public int Count { get; set; }
        private Node Head { get; set; }
        private Node Tail { get ; set; }

        public void Add(T data)
        {
            Node node = new Node(data, null);

            if (Head is null)
            {
                Head = node;
                Tail = node;
                
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            ++Count;
        }

        public T At(int index)
        {
            Node temp = Head;
            for(int i = 0; i < index; ++i)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        public int Find(T needle)
        {
            Node temp = Head;
            for(int i = 0; i < Count; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(needle, temp.Data))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
