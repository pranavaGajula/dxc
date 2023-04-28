namespace Interface_exercise
{
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car: IVehiculo
    {
        public int gasoline;
        public Car (int Gasoline)
        {
            gasoline = Gasoline;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is Driving");
            }
        }
        public bool Refuel(int amount)
        {
            gasoline += amount;
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("enter the amount of gasoline to refuel:");
            int amount = Convert.ToInt16(Console.ReadLine());
            car.Refuel(amount);
            car.Drive();
        }
    }
}