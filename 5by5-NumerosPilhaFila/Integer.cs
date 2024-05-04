using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_NumerosPilhaFila
{
    internal class Integer
    {
        int number;
        Integer next;
        Integer previous;
      
        public Integer(int number)
        {
            this.number = number;
            this.previous = null;
          
        }

        public override string? ToString()
        {
            return number + "";
        }
        public void setPrevious(Integer n)
        {
            this.previous = n;
        }
        public Integer getPrevious()
        {
            return this.previous;
        }
        public Integer getNext()
        {
            return this.next;
        }
        public void setNext(Integer n)
        {
            this.next = n;
        }
        public int getNumber()
        {
            return this.number;
        }
    }
}
