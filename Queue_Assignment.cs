using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Assignment
{
    public class Queue_Assignment
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Enqueue into Queue", node.data);
        }
        internal void Dequeue()
        {
            
            if(head==null)
            {
                Console.WriteLine("Queue is Empty.");
            }
            else
            {
                Node temp = head;
                this.head = temp.next;
                Console.WriteLine("{0} is Dequeue from Queue.", temp.data);
            }
            
            
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty.");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        internal int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                temp=temp.next;
                count++;
            }
            return count;
        }

    }
}
