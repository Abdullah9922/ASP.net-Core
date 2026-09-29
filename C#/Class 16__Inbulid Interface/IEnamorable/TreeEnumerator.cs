using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnamorable
{
    public class TreeEnumerator<T> : IEnumerator<T>
    {
        private List<T> values = new List<T>();

        private int index = -1;

        public TreeEnumerator(Node<T>? root)
        {
            Inorder(root);
        }

        private void Inorder(Node<T>? node)
        {
            if (node == null)
                return;

            Inorder(node.Left);

            values.Add(node.Value);

            Inorder(node.Right);
        }

        // Generic Current
        public T Current
        {
            get
            {
                if (index < 0 || index >= values.Count)
                    throw new InvalidOperationException();

                return values[index];
            }
        }

        // Non-generic Current
        object IEnumerator.Current => Current!;

        // Move to next item
        public bool MoveNext()
        {
            index++;

            return index < values.Count;
        }

        // Go back to beginning
        public void Reset()
        {
            index = -1;
        }

        // IDisposable
        public void Dispose()
        {
        }
    }
}
