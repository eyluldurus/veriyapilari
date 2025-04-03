// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public Node Next;
    public Node Prev;

    public Node(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

class CircularDoublyLinkedList
{
    private Node head;

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
            head.Prev = head;
        }
        else
        {
            Node tail = head.Prev;
            tail.Next = newNode;
            newNode.Prev = tail;
            newNode.Next = head;
            head.Prev = newNode;
        }
    }

    public void Delete(int key)
    {
        if (head == null) return;

        Node current = head;
        bool found = false;

        do
        {
            if (current.Data == key)
            {
                found = true;
                break;
            }
            current = current.Next;
        } while (current != head);

        if (found)
        {
            if (current == head && current.Next == head) 
            {
                head = null;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
                if (current == head) head = current.Next;
            }
        }
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş.");
            return;
        }

        Node temp = head;
        do
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CircularDoublyLinkedList list = new CircularDoublyLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        Console.WriteLine("Mevcut liste:");
        list.Display();

        list.Delete(20);
        Console.WriteLine("20 silindikten sonra liste:");
        list.Display();

        list.Delete(10);
        Console.WriteLine("10 silindikten sonra liste:");
        list.Display();
    }
}
