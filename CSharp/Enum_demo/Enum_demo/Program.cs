namespace Enum_demo
{ enum days { sunday,monday,tuesday,wednesday,thursday,friday,saturday}
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("sunday:"+(int)days.sunday);
            Console.WriteLine("Monday:" + (int)days.monday);
            Console.WriteLine("Tuesday:" + (int)days.tuesday);
            Console.WriteLine("Wednesday:" + (int)days.wednesday);
            Console.WriteLine("Thursday:" + (int)days.thursday);
            Console.WriteLine("Friday:" + (int)days.friday);
            Console.WriteLine("Saturday:" + (int)days.saturday);


        }
    }
}