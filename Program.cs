using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistAssignmentDay14
{
    internal class List2
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
                    Console.WriteLine(node.data + ":Inserted Succesfully");
             
                }
            
                else
                {
                    Node node1 = new Node(data);
                    Node h1 = null;
                    h1 = this.head;
                    this.head = node1;
                    Node temp = node1;
                    temp.next = h1;
                    Console.WriteLine(node1.data + ":Inserted Succesfully");
                }
            }
            public void Display()
            {
                if (this.head == null)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                   
                    Console.WriteLine("Values In LinkedList Are:");
                    while (this.head != null)
                    {
                        Console.WriteLine(this.head.data + " ");
                        this.head = this.head.next;
                    }
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                LinkedList ll = new LinkedList();
                ll.add(70);
                ll.add(30);
                ll.add(56);
                ll.Display();
            }
        }
    }
}
