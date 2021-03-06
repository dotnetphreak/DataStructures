﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    class MyLinkedList
    {
        public Node Head;
        public void Add(int data)
        {
            if (Head == null)
            {
                Head = new Node { Data = data };
                return;;
            }

            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            
            Node newNode = new Node {Data = data};
            temp.Next = newNode;
        }

        public void Remove(int data)
        {
            //empty case
            if (Head == null)
            {
                Console.WriteLine("empty");
                return;
            }
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node prev = Head;
            Node curr = prev.Next;

            while (curr != null)
            {
                if (data == curr.Data)
                {
                    prev.Next = curr.Next;
                    Console.WriteLine("Node deleted successfully");
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }
        }

        public void Print()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + "-> ");
                temp = temp.Next;
            }
            Console.Write("END");
        }

        public void DeleteNodeAtGivenPosition(int pos)
        {
            if (Head == null)
            {
                Console.WriteLine("Empty");
                return;
            }

            if (pos == 0)
            {
                Head = Head.Next;
                return;
            }

            Node prev = Head;
            Node curr = Head.Next;
            int count = 1;
            while (curr != null && count < pos)
            {
                count++;
                prev = curr;
                curr = curr.Next;
            }

            if (curr != null)
            {
                prev.Next = curr.Next;
                return;
            }

            if (pos>count)
            {
                Console.WriteLine("Index out of bound");
            }

        }

        public void LengthLinkedListIterative()
        {
            int length = 0;
            Node curr = Head;
            while (curr!=null)
            {
                length++;
                curr = curr.Next;
            }
            Console.WriteLine($"The lenght of linked list is {length}");
        }

        public void LengthLinkedListRecursive()
        {
            var length = this.LengthLinkedListRecursivePrivate(Head);
            Console.WriteLine($"The lenght of linked list is {length}");
        }

        private int LengthLinkedListRecursivePrivate(Node head)
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                return 1 + LengthLinkedListRecursivePrivate(head.Next);
            }
        }

        public void SearchElementRecursive(int data)
        {
            var exists = SearchElementRecursivePrivate(Head, data);
            Console.WriteLine(exists ? "Exists" : "Do Not exist");
        }

        private bool SearchElementRecursivePrivate(Node head, int data)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Data == data)
            {
                return true;
            }
            return SearchElementRecursivePrivate(head.Next, data);
        }

        public  void Reverse()
        {
            if (Head == null)
            {
                Console.WriteLine("Empty");
            }
            var ptr= ReversePrivate(Head);
            ptr.Next = null;
        }

        private Node ReversePrivate(Node head)
        {
            
            if (head.Next == null)
            {
                Head = head;
                return head;
            }
            var ptr = ReversePrivate(head.Next);
            ptr.Next = head;
            return head;
        }

        public void MergeLinkedListUsingRecursion()
        {
            
        }

}
}
