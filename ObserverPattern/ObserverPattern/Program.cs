// See https://aka.ms/new-console-template for more information
using ObserverPattern.Models;

Console.WriteLine("Hello, World!");

var random = new Random();
var weatherStation = new WeatherStation();

weatherStation.Add(new ComputerDisplay(weatherStation));
weatherStation.Add(new ComputerDisplay(weatherStation));
weatherStation.Add(new ComputerDisplay(weatherStation));
weatherStation.Add(new ComputerDisplay(weatherStation));
weatherStation.Add(new PhoneDisplay(weatherStation));
weatherStation.Add(new PhoneDisplay(weatherStation));
weatherStation.Add(new PhoneDisplay(weatherStation));
weatherStation.Add(new PhoneDisplay(weatherStation));


while (true)
{
    Thread.Sleep(2000);
    weatherStation.Temperature = random.Next(40);
    if (weatherStation.Temperature > 20)
        weatherStation.Notify();
}

Console.ReadLine();