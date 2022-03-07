using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QueueDemo
    {
        public void QueExample()
        {
            Queue queue = new Queue();
            queue.Enqueue("Lokesh");
            queue.Enqueue("Pramod");
            queue.Enqueue("Jhansi");
            queue.Enqueue("Pranesh");
            queue.Enqueue("Pranesh");
            Console.WriteLine("Queue Elements are  ");
            foreach(object ob in queue)
            {
                Console.WriteLine(ob);
            }

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("List after removing element from Queue...");
            foreach(object ob in queue)
            {
                Console.WriteLine(ob);
            }
        }
        static void Main()
        {
            new QueueDemo().QueExample();
        }
    }
}
