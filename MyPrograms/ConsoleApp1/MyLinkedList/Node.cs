using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LinkList
{
    class Node<T>
    {

        public Node() : this(default(T) , null, null)
        {

        }

        public Node(T data) : this(data, null, null)
        {

        }

        public Node(T data, Node<T> next) : this(data, next, null)
        { }

        public Node(T data, Node<T> next, Node<T> prev)
        {
            Data = data;
            NextNode = next;
            PrevNode = prev;
        }


        public Node<T> NextNode { set; get; }

        public Node<T> PrevNode { set; get; }

        public T Data { set; get; }
    }
}
