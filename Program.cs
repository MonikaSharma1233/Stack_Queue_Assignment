namespace Stack_and_Queue_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Pop();
            stack.IsEmpty();
            //stack.Display();
            //--------------------Queue---------------------
            Queue_Assignment qa = new Queue_Assignment();
            qa.Enqueue(56);
            qa.Enqueue(30);
            qa.Enqueue(70);
            qa.Display();
            qa.Dequeue();
            qa.Display();
            int size = qa.Size();
            Console.WriteLine("Size of Queue is: "+size);
        }
    }
}
