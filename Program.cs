    public class DailyTemperature
    {
        public int Day { get; }
        public double HighestTemperature { get; }
        public double LowestTemperature { get; }

        public DailyTemperature(int day, double highestTemperature, double lowestTemperature)
        {
            Day = day;
            HighestTemperature = highestTemperature;
            LowestTemperature = lowestTemperature;
        }

        public double TemperatureDifference()
        {
            return HighestTemperature - LowestTemperature;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DailyTemperature[] temperatures = new DailyTemperature[]
            {
            new DailyTemperature(1, 20, 10),
            new DailyTemperature(2, 25, 15),
            new DailyTemperature(3, 18, 8),
            new DailyTemperature(4, 30, 20)
            };

            int maxDifferenceDay = 0;
            double maxDifference = 0;

            foreach (var temperature in temperatures)
            {
                double difference = temperature.TemperatureDifference();
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    maxDifferenceDay = temperature.Day;
                }
            }

            Console.WriteLine($"День з максимальною різницею між найвищою і найнижчою температурою: {maxDifferenceDay}");
        }
    }
