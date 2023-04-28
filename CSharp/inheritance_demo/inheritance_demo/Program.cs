namespace inheritance_demo
{class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine($"{name}, I am an animal");
        }
    }
    class dog : Animal
    {
        public void getname()
        {
            Console.WriteLine($"my name is: {name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dog bark = new dog();
            bark.name = "tommy";
            bark.display();
            bark.getname();
            Console.WriteLine();
        }
    }
}