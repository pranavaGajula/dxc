using System.Collections;
namespace collections_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            string str = "Pranava Gajula";
            int x = 10;
            a.Add(str);
            a.Add(x);
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            Console.WriteLine(s.Contains(30));

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Remove with Pop Method");
            Console.WriteLine($"{s.Pop()} is popped out");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }

    }
}