using System;
using System.Collections.Generic;
namespace LinkLLinkedlistAssignmentDay14
{
    internal class List1
    {

        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        internal class LinkedList
        {

            Node head =null; //new 
            internal void Add(int data)
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

            }

            internal class List1
            {
                static void Main(string[] args)
                {
                    LinkedList<int> list = new LinkedList<int>();  //Create Linked List Object
                    list.AddFirst(56);
                    list.AddFirst(30);
                    list.AddFirst(70);

                    foreach (int val in list)
                    {
                        Console.WriteLine(val + "inserted into the linked list");//Print data using For Each Loop
                    }
                }
            }
        }
    }
}