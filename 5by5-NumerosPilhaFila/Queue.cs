using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_NumerosPilhaFila
{
    internal class Queue
    {
        Integer head;
        Integer tail;

        public Queue()
        {
            this.head = null;
            this.tail = null;
        }
        bool IsEmpty()
        {
            return head == null && tail == null;
        }
        public void Push(Integer aux_queue)
        {
            if (IsEmpty())
            {
                head = tail = aux_queue;
            }
            else
            {
                this.tail.setNext(aux_queue);
                tail = aux_queue;
            }
        }
        public void Print()
        {
            Integer aux_queue = head;
            if (IsEmpty())
            {
                Console.WriteLine("Empty queue, nothing for print");
            }
            else
            {
                do
                {
                    Console.Write(" " + aux_queue.ToString());
                    aux_queue = aux_queue.getNext();

                } while (aux_queue != null);


            }
            Console.WriteLine();
        }
        public Integer getHead() { return head; }
        
    }
}
