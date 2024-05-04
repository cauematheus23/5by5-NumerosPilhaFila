using _5by5_NumerosPilhaFila;
int[] repeat = new int[10];
Stack stack1 = new Stack();
Queue queue1 = new Queue();

void BrowseEquals(Stack stack, Queue queue)
{
    int cont = 0 ;
    Integer ax;

   for (Integer browse_stack = stack.getTop();browse_stack != null; browse_stack.getPrevious())
    {
        for(Integer browse_queue = queue.getHead();browse_queue != null; browse_queue.getNext())
        {
            if(browse_stack.getNumber() == browse_queue.getNumber())
            {
                repeat[cont] = browse_stack.getNumber();
                cont++;
            }
        }
    }
}


for (int i = 0; i < 10; i++)
{

}
