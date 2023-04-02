using ObserverPattern.Interfaces;
namespace ObserverPattern.Models
{
    public class ComputerDisplay : IObserver
    {
        private WeatherStation _station;
        public Guid DeviceNumber { get; set; } = Guid.NewGuid();
        public ComputerDisplay(WeatherStation weatherStation)
        {
            _station = weatherStation;
        }
        public void Update()
        {
            var temperature = _station.Temperature;
            if(temperature > 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Temperature is {temperature}, higher than 30, Device Number: {DeviceNumber}");
            }
        }
    }
}
