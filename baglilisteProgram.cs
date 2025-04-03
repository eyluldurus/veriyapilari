// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public void Delete(int key)
    {
        if (head == null) return;

        Node temp = head, prev = null;

        if (temp != null && temp.Data == key)
        {
            head = temp.Next;
            return;
        }

        while (temp != null && temp.Data != key)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null) return;

        prev.Next = temp.Next;
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş.");
            return;
        }

        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

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
