using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();
            heap.insert(10);
            heap.insert(17);
            heap.insert(5);
            heap.insert(4);
            heap.insert(22);
            heap.remove();

            //Sort array items in ascending order

            //not working..
            heap.sortAscending(new int[5] { 5, 20, 11, 7, 8 });
            Console.WriteLine("----------------------");
            heap.sortDescending(new int[5] { 5, 20, 11, 7, 8 });

            MaxHeap.heapify(new int[6] { 5, 3, 8, 4, 1, 2 });

            MaxHeap maxHeap = new MaxHeap();
            var kthLargest = maxHeap.getKthLargestNumber(new int[6] { 5, 3, 8, 4, 1, 2 }, 3);
            Console.WriteLine("Kth Largest number is :" + kthLargest);

            Console.WriteLine("-----------HeapExercise----------");
            HeapExercise heapExercise = new HeapExercise();
            var isMaxHeap = heapExercise.isMaxHeap(new int[6] { 8, 4, 5, 3, 10, 2 });
            Console.WriteLine("Is this is a Max Heap -> { 5, 3, 8, 4, 1, 2 } :" + isMaxHeap);

            Console.ReadLine();

        }
    }
}
