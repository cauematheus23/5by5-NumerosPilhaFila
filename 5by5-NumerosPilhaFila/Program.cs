using _5by5_NumerosPilhaFila;
int[] repeat = new int[10];
Stack stack1 = new Stack();
Queue queue1 = new Queue();
int cont = 0 ;

void BrowseEquals(Stack stack, Queue queue)
{
    Integer ax;

   for (Integer browse_stack = stack.getTop();browse_stack != null; browse_stack = browse_stack.getPrevious())
    {
        for(Integer browse_queue = queue.getHead();browse_queue != null; browse_queue = browse_queue.getNext())
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
    stack1.Push(new(new Random().Next(1,20)));
}for (int i = 0; i < 10; i++)
{
    queue1.Push(new(new Random().Next(1,20)));
}
Console.WriteLine("===== IN STACK =====");
stack1.Print();
Console.WriteLine("===== IN QUEUE =====");
queue1.Print();
Console.WriteLine("===== IN STACK AND QUEUE =====");
BrowseEquals(stack1, queue1);
for(int i =0; i < cont; i++)
{
    int aux = repeat[i];
    Console.Write(aux + " ");
    while(i < cont && repeat[i] == aux)
    {
        i++;
    }
}
