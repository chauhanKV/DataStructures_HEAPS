using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class MinHeap
    {

        private class Node
        {
            private int key;
            private string value;
            public Node(int key, string value)
            {
                this.Key = key;
                this.Value = value;
            }

            public int Key { get => key; set => key = value; }
            public string Value { get => value; set => this.value = value; }
        }

        Node[] nodes = new Node[5];
        int count = 0;

        public void insert(int key, string value)
        {
            if (isFull())
            {
                Console.WriteLine("Heap is full. Cannot enter more values.");
                return;
            }

            var node = new Node(key, value);
            nodes[count++] = node;

            bubbleUp();
        }

        public int remove()
        {
            if (isEmpty())
                throw new Exception("Nothing to remove. Heap is empty.");

            Node removedNode = nodes[0];
            nodes[0] = nodes[--count];
            bubbleDown();
            return removedNode.Key;
        }

        private bool isFull()
        {
            return nodes.Length == count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        private void bubbleDown()
        {
            int index = 0;
            while (index < count && !isValidRoot(index))
            {
                swap(index, smallestIndex(index));
                index = smallestIndex(index);
            }

        }

        private int smallestIndex(int index)
        {
            if (hasLeftChild(index))
                return leftChildIndex(index);

            return leftChild(index).Key < rightChild(index).Key ? leftChildIndex(index) : rightChildIndex(index);
        }

        private bool isValidRoot(int index)
        {
            if (!hasLeftChild(index))
                return true;

            if (!hasRightChild(index))
                return nodes[index].Key > leftChild(index).Key;

            return nodes[index].Key < leftChild(index).Key && nodes[index].Key < rightChild(index).Key;
        }

        private Node leftChild(int index)
        {
            return nodes[leftChildIndex(index)];
        }

        private Node rightChild(int index)
        {
            return nodes[rightChildIndex(index)];
        }

        private bool hasLeftChild(int index)
        {
            return leftChildIndex(index) <= count;
        }

        private bool hasRightChild(int index)
        {
            return rightChildIndex(index) <= count;
        }

        private int leftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private int rightChildIndex(int index)
        {
            return (index * 2) + 2;
        }

        private void bubbleUp()
        {
            int index = count - 1;
            while (index > 0 && nodes[index].Key < nodes[parent(index)].Key)
            {
                swap(index, parent(index));
                index = parent(index);
            }
        }

        private void swap(int childIndex, int parentIndex)
        {
            var temp = nodes[parentIndex];
            nodes[parentIndex] = nodes[childIndex];
            nodes[childIndex] = temp;
        }

        private int parent(int index)
        {
            return (index - 1) / 2;
        }

        public string print()
        {
            return String.Join(",", nodes.Select(n => n.Key.ToString()).ToArray());
        }

    }
}
