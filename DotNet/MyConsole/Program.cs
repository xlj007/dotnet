using System;
using MyApp;
using Strategy;
using ObserverPattern;
using Decorator;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage1 = new HouseBlend();
            beverage1 = new Soy(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");
        }
    }
}
