using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private int number;
        private List<Node<T>> children = new List<Node<T>>();
        public T Data { get; set; }

        public int Number
        {
            get { return this.number; }
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public Node(T data)
        {
            Data = data;
        }

        public void AddChildren(Node<T> child)
        {
            this.children.Add(child);
        }
    }
}

