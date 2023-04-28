namespace constructors_demo
{
    class demo
    {
        public demo()
        {
            Console.WriteLine("a");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("b");
            int b = Convert.ToInt16(Console.ReadLine());

            int c=a+b;
            Console.WriteLine(c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
        }
    }
}