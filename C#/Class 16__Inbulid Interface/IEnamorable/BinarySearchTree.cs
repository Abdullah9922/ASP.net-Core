using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnamorable
{
    public class BinarySearchTree<T> : IEnumerable<T>
    {
        private Node<T>? root;

        // =========================
        // ADD
        // =========================
        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node<T>(value);
                return;
            }

            AddNode(root, value);
        }

        private void AddNode(Node<T> node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node<T>(value);
                }
                else
                {
                    AddNode(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(value);
                }
                else
                {
                    AddNode(node.Right, value);
                }
            }
        }


        // =========================
        // IEnumerable<int>
        // =========================
        public IEnumerator<T> GetEnumerator()
        {
            return new TreeEnumerator<T>(root);
        }

        // IEnumerable-এর non-generic version
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
