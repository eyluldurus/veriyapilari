// See https://aka.ms/new-console-template for more information
using System;

class Stack
{
    private int[] elements;
    private int top;
    private int max;

    public Stack(int size)
    {
        elements = new int[size];
        top = -1;
        max = size;
    }

    public void Push(int data)
    {
        if (top == max - 1)
        {
            Console.WriteLine("Stack dolu, eleman eklenemez");
            return;
        }
        elements[++top] = data;
        Console.WriteLine(data + " stack'e eklendi");
    }

    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack boş, eleman çıkarılamaz");
            return;
        }
        Console.WriteLine(elements[top] + " stack'ten çıkarıldı");
        top--;
    }

    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack boş");
            return;
        }
        Console.WriteLine("Stack'in en üstündeki eleman: " + elements[top]);
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack boş");
            return;
        }
        Console.WriteLine("Stack içerisindeki elemanlar:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(elements[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        stack.Display();

        stack.Pop();
        stack.Pop();

        stack.Peek();
        stack.Display();
    }
}
