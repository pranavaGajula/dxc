namespace Generic_demo
{public class student<T>
    {
        public T data;
        public student(T data)
        {
            this.data = data;
            Console.WriteLine($"data passed {this.data}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student<string> studentname = new student<string>("Pranava");
            student<int> studentid = new student<int>(23);

        }
    }
}