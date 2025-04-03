using System;
using System.Collections.Generic;

class Stack<T>
{
    private List<T> items = new List<T>();

    // Veriyi yığına eklemek için Push metodu
    public void Push(T item)
    {
        items.Add(item);
    }

    // Yığının üstündeki elemanı çıkarmak için Pop metodu
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    // Yığının üstündeki elemanı almak için Peek metodu
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        return items[items.Count - 1];
    }

    // Yığının boş olup olmadığını kontrol etme
    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    // Yığındaki eleman sayısını almak için
    public int Count()
    {
        return items.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        // Elemanları yığına ekleyelim
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Yığının en üstündeki elemanı görelim
        Console.WriteLine("Peek: " + stack.Peek());  // 30

        // Pop işlemi ile elemanları çıkaralım
        Console.WriteLine("Pop: " + stack.Pop());  // 30
        Console.WriteLine("Pop: " + stack.Pop());  // 20

        // Yığının boş olup olmadığını kontrol edelim
        Console.WriteLine("Is stack empty? " + stack.IsEmpty());  // False

        Console.WriteLine("Pop: " + stack.Pop());  // 10

        Console.WriteLine("Is stack empty? " + stack.IsEmpty());  // True
    }
}
