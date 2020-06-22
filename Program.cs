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


            Console.WriteLine("-----------MinHeap----------");
            MinHeap minHeap = new MinHeap();
            minHeap.insert(30, "A");
            minHeap.insert(3, "B");
            minHeap.insert(60, "C");
            minHeap.insert(1, "D");
            minHeap.insert(10, "E");
            //minHeap.insert(2, "F");

            Console.WriteLine(minHeap.print());

            Console.WriteLine("Removed value is from MinHeap is : " + minHeap.remove());

            Console.WriteLine("-----------PriorityQueueWithMinHeap----------");
            PriorityQueueWithMinHeap priorityQueueWithMinHeap = new PriorityQueueWithMinHeap();
            priorityQueueWithMinHeap.add("Kavita", 5);
            priorityQueueWithMinHeap.add("Brother", 3);
            priorityQueueWithMinHeap.add("Mom", 1);
            priorityQueueWithMinHeap.add("Dad", 2);
            priorityQueueWithMinHeap.add("Brother", 3);

            Console.WriteLine(priorityQueueWithMinHeap.print());

            Console.WriteLine("Value removed from Priority Queue using MinHeap is : " + priorityQueueWithMinHeap.remove());



            Console.ReadLine();

        }
    }
}
