using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_NumerosPilhaFila
{
    internal class Stack
    {
        int number;
        Integer top;
        

        public Stack()
        {
            this.top = null;
           
        }
        bool IsEmpty()
        {
            return this.top == null;
        }

        public void Push(Integer aux_stack)
        {
            if (IsEmpty())
            {
                this.top = aux_stack;
            }
            else
            {

                aux_stack.setPrevious(top);
                top = aux_stack;
            }
        }
        public void Print()
        {
            Integer aux_stack = this.top;
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty, nothing to print!");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux_stack.ToString());
                    aux_stack = aux_stack.getPrevious();
                } while (aux_stack != null);
            }
        }
        public Integer getTop()
        {
            return top;
        }
    }
}
