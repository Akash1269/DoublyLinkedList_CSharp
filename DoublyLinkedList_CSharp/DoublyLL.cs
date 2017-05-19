using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList_CSharp
{
    class DoublyLL
    {
        public Node Head { get; set; }
        
        public void InsertAtStart(int data)
        {
            Node node = new Node() { Data = data, Next = null, Prev = null };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
            }
        }
        public void DeleteAtStart()
        {
            if(Head == null || Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
        }
        public void InsertAtEnd(int data)
        {
            Node node = new Node() { Data = data, Next = null, Prev = null };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                node.Prev = temp;
            }
        }
        public void DeleteAtEnd()
        {
            if (Head == null || Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Node temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
            }
        }
        public bool DeleteNode(int data)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    Node prev = temp.Prev;
                    Node next = temp.Next;
                    if (prev != null)
                    {
                        prev.Next = next;
                    }
                    else
                    {
                        Head = next;
                    }
                    if (next != null)
                    {
                        next.Prev = prev;
                    }
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void PrintAll()
        {
            Node temp = Head;
            Console.WriteLine();
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null\n");
        }

        public void PrintReverse()
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Prev;
            }
            Console.WriteLine("null\n");
        }

    }
}
