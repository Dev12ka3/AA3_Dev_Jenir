internal static class ArrayQueueHelpers
{
    
    public static void Main(string[] args)
    {
        ArrayQueue<char> q = new ArrayQueue<char>();

        for (int i = 0; i < 8; i++)
        {
            q.add((char)('a' + i));
            q.PrintQueue();
        }


        q.add('a');
        q.add('a');
        q.add('a');
        q.PrintQueue();

        for (int i = 0; i < 8; i++)
        {
            q.remove();
            q.PrintQueue();

           
        }
        q.add('b');
        q.remove();
        q.add('c');
        q.remove();
        q.PrintQueue();
        q.add('d');
        q.PrintQueue();
        q.add('e');
        q.PrintQueue();
        q.remove();
        q.PrintQueue();
        q.add('f');
        q.PrintQueue();
        q.add('g');
        q.PrintQueue();
        q.add('h');
        q.PrintQueue();
        q.remove();
        q.PrintQueue();

    } 
}