using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    public class PhoneDisplay : IObserver
    {
        private WeatherStation _station;

        public PhoneDisplay(WeatherStation weatherStation)
        {
            _station = weatherStation;
        }
        public Guid DeviceNumber { get; set; } = Guid.NewGuid();
        public void Update()
        {
            var temperature = _station.Temperature;
            if(temperature > 25)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Temperature is: {temperature}, higher than 25, Device Number: {DeviceNumber}");
            }
        }
    }
}
