
using LinkedlistAssignmentDay14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistAssignmentDay14
{
    internal class List5
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
            internal void add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
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
                Console.WriteLine(node.data + ":Inserted SuccessFully");
            }
            internal void popfirstdata(int data)
            {
                this.head = this.head.next;
                Console.WriteLine("First Element Is Removed");
            }
            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked List Is Empty");
                }
                else
                {
                    while (temp != null)
                    {
                        Console.WriteLine(temp.data + " ");
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
                ll.add(56);
                ll.add(30);
                ll.add(70);
                ll.Display();
                Console.WriteLine("Before Pop First element  Elements are shown above");
                ll.popfirstdata(56);
                ll.Display();
                Console.WriteLine("After Pop First element  Elements are shown above");


            }
        }


    }
}


