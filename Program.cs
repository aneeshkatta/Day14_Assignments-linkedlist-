
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistAssignmentDay14
{
    internal class List4
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
            public int position = 1;
            public int count = 1;
            public LinkedList()
            {
                this.position = position;
                this.count = count;
            }

            Node head = null;
            public void add(int position,int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                    Console.WriteLine(node.data + ":Inserted Succesfully");
                   
                    
                    Console.WriteLine(count + ":POSITION");
                    count++;
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

                    Console.WriteLine(count + ":POSITION");
                    count++;
                }
            }
            internal Node InsertAtParticularPosition(int position, int data)
            {
                if (position < 1)
                    Console.WriteLine("Invalid position");
                if (position == 1)
                {
                    var newNode = new Node(data);
                    newNode.next = this.head;
                    head = newNode;
                }
                else
                {
                    Node temp = this.head;
                    while (position != 0) 
                    {

                        if (position> 1)
                        {
                            Node node = new Node(data);
                            node.next = this.head.next;
                            head.next = node;
                            break;
                        }
                        temp = temp.next;//1000
                        position--;
                    }
                   
                }
                return this.head;
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
                    while (this.head != null && this.position!=count+1)
                    {
                        Console.WriteLine(this.head.data + ":Data ");
                        Console.WriteLine(Math.Abs(this.position) + ":position ");
                        this.head = this.head.next;
                        position++;
                    }
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                LinkedList ll = new LinkedList();
                ll.add(1,70);
                ll.add(2,56);
                ll.InsertAtParticularPosition(2,30);
                ll.Display();
            }
        }
    }
}
