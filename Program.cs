using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistAssignmentDay14
{
    internal class List3
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
        public class LinkedList
        {
            Node head = null;
            public void add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;

                }
                else
                {
                    Node temp = this.head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine(node.data + ":Inserted Succesfully");
            }
            public void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList Is Empty");
                }
                else
                {

                    while (temp != null)
                    {
                        Console.Write(temp.data + " ");
                        temp = temp.next;
                    }
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                LinkedList ll = new LinkedList();
                ll.add(30);
                ll.add(70);
                ll.add(56);
                ll.Display();
            }
        }
    }
}
