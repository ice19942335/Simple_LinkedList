using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;  //First element
        private Node<T> _tail;  //LAst element
        private int _count;     //Element in list

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head is null)
            {
                _head = node;
            }
            else
            {
                if(_tail != null)
                    _tail.Next = node;
            }
            
            _tail = node;
            _count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    //If node is not first in list
                    if (previous != null)
                    {
                        //Removing current node, now previous linked with next node
                        previous.Next = current.Next;

                        // If 'current.Next is null' it means node is last in the list
                        if (current.Next is null)
                            _tail = previous;
                    }
                    else
                    {
                        //If deleting first element, rewriting head node
                        _head = _head.Next;

                        if (_head is null)
                            _tail = null;
                    }

                    _count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public int Count => _count;

        public bool IsEmpty => _count == 0;

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public void AppendInFront(T data)
        {
            Node<T> node = new Node<T>(data);

            node.Next = _head;
            _head = node;

            if (_count == 0)
                _tail = _head;

            _count++;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
