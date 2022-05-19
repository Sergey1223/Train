namespace Train
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Train train = new Train();
            Observer observer = new Observer();
            
            Console.WriteLine("Count of wagons: " + observer.CountWagons(train));
        }
    }
}