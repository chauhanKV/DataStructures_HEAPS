using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class MaxHeap
    {
        public static int[] heapify(int[] array)
        {
            for (int i = 0; i < lastParent(array); i++)
            {
                if (isRootSmallerThanChildren(array, i))
                {
                    var temp = array[i];
                    array[i] = array[maxChildIndex(array, i)];
                    array[maxChildIndex(array, i)] = temp;
                }
            }

            return array;
        }

        public int getKthLargestNumber(int[] array, int k)
        {
            if (k < 1 || k > array.Length)
                throw new IndexOutOfRangeException();

            var heap = new Heap();
            foreach (int item in array)
            {
                heap.insert(item);
            }

            for (int i = 0; i < (k - 1); i++)
            {
                heap.remove();
            }

            return heap.max();
        }

        private static int leftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private static int rightChildIndex(int index)
        {
            return (index * 2) + 2;
        }

        private static int lastParent(int[] array)
        {
            return (array.Length / 2 - 1);
        }

        private static int maxChildIndex(int[] array, int index)
        {
            return array[leftChildIndex(index)] > array[rightChildIndex(index)] ? leftChildIndex(index) : rightChildIndex(index);
        }

        private static bool isRootSmallerThanChildren(int[] array, int index)
        {
            return array[index] < array[leftChildIndex(index)] || array[index] < array[rightChildIndex(index)];
        }
    }
}
