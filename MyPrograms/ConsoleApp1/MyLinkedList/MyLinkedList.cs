using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LinkList
{
    class MyLinkedList<T>
    {
        // add (object)
        // add (int position , obj)
        // remove
        // isempty
        // replace(int position, obj)
        // get
        // contains
        // clear
        // count

        private Node<T> head;
        private Node<T> end;

        public MyLinkedList()
        {
            head = null;
            end = null;
        }
        public int Count { get; private set; } = 0;

        public T this[int index]
        {
            get
            {
                return Get(index);
            }
        }

        public void Add(T data)
        {
            Add(Count, data);
        }

        public void Add(int position, T data)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(position.ToString());
            }
            else if (position > Count)
            {
                throw new IndexOutOfRangeException(position.ToString());
            }

            Node<T> current = head;

            if (IsEmpty())
            {
               end = head = new Node<T>(data, head, null);
            }
            else if ( position == 0)
            {
                current.PrevNode = head = new Node<T>(data, head, null);
            }
            else
            {
                int index = 0;

                while (index < position - 1)
                {
                    current = current.NextNode;
                    index++;
                }

                Node<T> node = new Node<T>(data, current.NextNode, current);
                current.NextNode = node;

                if (position == Count)
                {
                    end = node;
                }
            }



            Count++;
        }

        public void Remove(int position)
        {
            if (position < 0 || IsEmpty())
            {
                throw new ArgumentOutOfRangeException(position.ToString());
            }
            else if (position > Count)
            {
                throw new IndexOutOfRangeException(position.ToString());
            }

            Node<T> current = head;

            if (position == 0)
            {
                current = current.NextNode;
                head = current;
                current.PrevNode = null;
            }else if(position == Count - 1)
            {
                current = end;
                var prevNode = current.PrevNode;
                prevNode.NextNode = null;
                end = prevNode;                
            }

            else
            {
                int index = 0;

                while (index < position)
                {
                    current = current.NextNode;
                    index++;
                }

                var nextNode = current.NextNode;
                var prevNode = current.PrevNode;
                prevNode.NextNode = current.NextNode;
                nextNode.PrevNode = prevNode;
            }

            Count--;
        }

        public void Replace(int position, T data)
        {
            if (position < 0 || IsEmpty())
            {
                throw new ArgumentOutOfRangeException(position.ToString());
            }
            else if (position > Count)
            {
                throw new IndexOutOfRangeException(position.ToString());
            }

            Node<T> current = head;
            int index = 0;
            while (index < position)
            {
                current = current.NextNode;
                index++;
            }

            current.Data = data;

        }


        public bool Contains(T data)
        {
            bool found = false;
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    found = true;
                    break;
                }

                current = current.NextNode;
            }

            return found;
        }

        public void Clear()
        {
            Count = 0;
            head = null;
            end = null;
        }

        public bool IsEmpty()
        {
            return head is null;
        }

        public void Print()
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.NextNode;
            }
            Console.WriteLine("\n");
        }

        public void ReversePrint()
        {
            var current = end;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.PrevNode;
            }
            Console.WriteLine("\n");
        }

        public T Get(int position)
        {
            if (position < 0 || IsEmpty())
            {
                throw new ArgumentOutOfRangeException(position.ToString());
            }
            else if (position > Count)
            {
                throw new IndexOutOfRangeException(position.ToString());
            }

            var current = head;
            int index = 0;
            while (index < position)
            {
                current = current.NextNode;
                index++;
            }

            return current.Data;
        }
    }
}
