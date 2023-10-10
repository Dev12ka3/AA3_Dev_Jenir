using System;

public class ArrayQueue<T>
{
    protected T[] a;
    private int j;
    private int n;

    public ArrayQueue()
    {
        a = new T[1];
        j = 0;
        n = 0;
    }

    public void add(T x)
    {
        if (n + 1 > a.Length)
            resize();
        a[(j + n) % a.Length] = x;
        n++;
    }

    public T remove()
    {
        if (n == 0)
            throw new InvalidOperationException("Queue is empty.");
        T x = a[j];
        j = (j + 1) % a.Length;
        n--;
        if (a.Length >= 3 * n)
            resize();
        return x;
    }

    private void resize()
    {
        T[] b = new T[Math.Max(1, n * 2)];
        for (int k = 0; k < n; k++)
            b[k] = a[(j + k) % a.Length];
        a = b;
        j = 0;
    }

    public void PrintQueue()
    {
        Console.Write("Queue: [");
        for (int i = 0; i < n; i++)
        {
            int index = (j + i) % a.Length;
            Console.Write($"{a[index]}");
            if (i < n - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }




}