using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class PriorityQueueWithHeap
    {
        //                          Insert      Delete    
        // priorityQueues           O(n)         O(n)
        // PriorityQueuesWithHeap   O(log(n))    O(log(n))

        private Heap heap = new Heap();

        public void enqueue(int value)
        {
            heap.insert(value);
        }

        public int dequeue()
        {
            return heap.remove();        
        }

        public bool isEmpty()
        {
            return heap.isEmpty();
        }

        public int size()
        {
            return heap.size();
        }
    }
}
