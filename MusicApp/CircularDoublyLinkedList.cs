using System;

namespace MusicApp
{
    public class CircularDoublyLinkedList<T>
    {
        public uint Count { get; private set; }
        private Node? _head;
        public bool IsEmpty => Count == 0;


        public CircularDoublyLinkedList()
        {
            Count = 0;
            _head = null;
        }


        public void Append(T value)
        {
            Node newNode = new(value);
            // if empty, then simply make the new node the head of the list
            if (_head == null)
            {
                _head = newNode;
                _head.Next = _head;
                _head.Prev = _head;
            }
            // else, add it to the end of the list
            else
            {
#pragma warning disable CS8600, CS8602      // `_head.Prev` is never null, so suppress this warning
                Node tail = _head.Prev;
                tail.Next = newNode;        // tail points forward to new node
#pragma warning restore CS8600, CS8602
                newNode.Next = _head;       // new node points forward to head
                newNode.Prev = tail;        // and points back to tail
            }
            Count++;
        }


        public void Prepend(T value)
        {
            Node newNode = new(value);
            if (_head == null)
            {
                _head = newNode;
                _head.Next = _head;
                _head.Prev = _head;
            }
            else
            {
#pragma warning disable CS8600, CS8602      // `_head.Prev` is never null, so suppress this warning
                Node tail = _head.Prev;
                tail.Next = newNode;
#pragma warning restore CS8600, CS8602
                newNode.Next = _head;
                newNode.Prev = tail;
            }
            Count++;
        }


        public void InsertAfter(T value, uint index)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == Count - 1)
            {
                Append(value);
                return;
            }
#pragma warning disable CS8602, CS8600
            Node? current = _head;
            for (uint i = 0; i < index; i++)
            {
                current = current.Next;
            }
            Node newNode = new(value, current.Next, current);
            current.Next.Prev = newNode;
            current.Next = newNode;
#pragma warning restore CS8602, CS8600
        }


        public void InsertBefore(T value, uint index)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                Prepend(value);
                return;
            }
            InsertAfter(value, index - 1);
        }


        public void RemoveFirst()
        {
            if (_head == null)
            {
                throw new InvalidOperationException(
                    "Attempted to remove element from empty list!"    
                );
            }
#pragma warning disable CS8600, CS8602
            Node headNext = _head.Next;
            Node tail = _head.Prev;
            tail.Next = headNext;
            headNext.Prev = tail;
            _head = headNext;
#pragma warning restore CS8600, CS8602
        }


        public void RemoveLast()
        {
            if (_head == null)
            {
                throw new InvalidOperationException(
                    "Attempted to remove element from empty list!"
                );
            }
#pragma warning disable CS8600, CS8602
            Node prevTail = _head.Prev.Prev;
            _head.Prev = prevTail;
            prevTail.Next = _head;
#pragma warning restore CS8600, CS8602
        }


        public void RemoveAt(uint index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                RemoveFirst();
                return;
            }
            else if (index == Count - 1)
            {
                RemoveLast();
                return;
            }
#pragma warning disable CS8600, CS8602
            Node current = _head;
            for (uint i = 0; i < index - 1; i++)
            {
                current = current.Next;     // loop to the node before the given index
            }
            Node nextOfNext = current.Next.Next;
            current.Next = nextOfNext;
            nextOfNext.Prev = current;
#pragma warning restore CS8600, CS8602
        }


        public T Get(uint index)
        {
            if (index >= Count) throw new IndexOutOfRangeException();

            Node? current = _head;
#pragma warning disable CS8602                  // current can never be null
            for (uint i = 0; i < index; i++)
            {
                current = current.Next;         // loop to the node at the given index
            }
            return current.Value;
#pragma warning restore CS8602
        }


        public bool Remove(T value)
        {
            Node? current = _head;
            for (uint i = 0; i < Count; i++)
            {
#pragma warning disable CS8602
                if (current.Value.Equals(value))
                {
                    current.Next.Prev = current.Prev;
                    current.Prev.Next = current.Next;
                    return true;
                }
#pragma warning restore CS8602
                current = current.Next;
            }
            return false;
        }


        public void Clear()
        {
            _head = null;
            Count = 0;
        }


        protected class Node
        {
            public T Value { get; set; }
            public Node? Next { get; set; }
            public Node? Prev { get; set; }

            public Node(T value, Node? next = null, Node? prev = null)
            {
                Value=value;
                Next = next;
                Prev = prev;
            }
        }


        private class EmptyListException : Exception
        {
            public EmptyListException() : base() { }
        }
    }
}
