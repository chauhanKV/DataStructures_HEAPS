using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class PriorityQueueWithMinHeap
    {
        MinHeap minHeap = new MinHeap();
        public void add(string value, int priority)
        {
            minHeap.insert(priority, value);
        }

        public int remove()
        {
            return minHeap.remove();
        }

        public void isEmpty()
        {
            minHeap.isEmpty();
        }

        public string print()
        {
            return minHeap.print();
        }
    }
}
