using ObserverPattern.Interfaces;
namespace ObserverPattern.Models
{
    public class WeatherStation : IObservable
    {
        private readonly List<IObserver>? Observers = new List<IObserver>();
        public int Temperature { get; set; }
        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public int GetTemperature()
        {
            return Temperature;
        }
    }
}
