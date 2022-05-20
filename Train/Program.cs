namespace Train
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Train train = new Train();
            
            Console.WriteLine("Count of wagons: " + Observer.CountWagons(train));
        }
    }
}