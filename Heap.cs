using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class Heap
    {
        private int[] heap = new int[10];
        private int count;
        public void insert(int value)
        {
            if (isFull())
                throw new Exception("Heap is Full"); //reSizeHeap();

            heap[count++] = value;

            bubbleUp();
        }

        public int remove()
        {
            if (isEmpty())
                throw new Exception("Heap is empty. Cannot remove!");

            int removedValue = heap[0];
            heap[0] = heap[--count];

            bubbleDown();

            return removedValue;
        }

        public void sortDescending(int[] array)
            {
            var items = insertInNewHeap(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(items.remove());
            }
        }

        public void sortAscending(int[] array)
        {
            var items = insertInNewHeap(array);

            for (int i = (array.Length - 1); i >= 0; i--)
            {
                array[i] = items.remove();
            }

            Console.WriteLine(String.Join(",", array.Select(a => a.ToString()).ToArray()));
        }

        public int max()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            return heap[0];
        }

        private Heap insertInNewHeap(int[] array)
        {
            Heap items = new Heap();
            for (int i = 0; i < array.Length; i++)
            {
                items.insert(array[i]);
            }

            return items;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int size()
        {
            return count;
        }

        private void bubbleDown()
        {
            var index = 0;
            // check if the new root is valid
            while (index <= count && !isValidRoot(index))
            {
                // Get the largerChild
                swap(index, largerChildIndex(index));
                index = largerChildIndex(index);

            }
        }

        private int largerChild(int index)
        {
            return heap[largerChildIndex(index)];
        }

        private int largerChildIndex(int index)
        {
            if (!hasLeftChild(index))
                return index;

            if (!hasRightChild(index))
                return leftChildIndex(index);

            return leftChild(index) > rightChild(index) ? leftChildIndex(index) : rightChildIndex(index);
        }

        private bool hasLeftChild(int index)
        {
            return leftChildIndex(index) <= count;
        }

        private bool hasRightChild(int index)
        {
            return rightChildIndex(index) <= count;
        }

        private bool isValidRoot(int index)
        {
            if (!hasLeftChild(index))
                return true;

            if (!hasRightChild(index))
                return heap[index] >= leftChild(index);

            return heap[index] >= leftChild(index) && heap[index] >= rightChild(index);
        }

        private int leftChild(int index)
        {
            return heap[leftChildIndex(index)];
        }

        private int leftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private int rightChild(int index)
        {
            return heap[rightChildIndex(index)];
        }

        private int rightChildIndex(int index)
        {
            return (index * 2) + 2; 
        }

        private void reSizeHeap()
        {
            int[] newHeap = new int[count * 2];
            for (int i = 0; i < heap.Length; i++)
            {
                newHeap[i] = heap[i];
            }

            heap = newHeap;
        }

        private bool isFull()
        {
            return heap.Length == count;
        }
        private void bubbleUp()
        {
            var index = count - 1;
            while (index > 0 && heap[index] > heap[parent(index)])
            {
                swap(index, parent(index));
                index = parent(index);
            }
        }

        private int parent(int index)
        {
            return (index - 1) / 2;
        }

        private void swap(int first, int second)
        {
            var temp = heap[first];
            heap[first] = heap[second];
            heap[second] = temp;
        }
    }
}
