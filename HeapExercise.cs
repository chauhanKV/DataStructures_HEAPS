using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class HeapExercise
    {

        public bool isMaxHeap(int[] array)
        {
            return isThisMaxHeap(array, 0);
        }

        private bool isThisMaxHeap(int[] array, int index)
        {
            var leftChildIndex = index * 2 + 1;
            var rightChildIndex = index * 2 + 2;

            if (leftChildIndex >= array.Length)
                return true;

            if (rightChildIndex >= array.Length)
                return array[index] > array[leftChildIndex];

            var isValidParent =
                array[index] > array[leftChildIndex] &&
                array[index] > array[rightChildIndex];

            return isValidParent &&
                    isThisMaxHeap(array, leftChildIndex) &&
                    isThisMaxHeap(array, rightChildIndex);
        }

     
    }
}
