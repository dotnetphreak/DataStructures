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
        private Node Head;
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
            if (Head.Next == null)
            {
                if (data == Head.Data)
                {
                    Head = null;
                }
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

        
    }
}