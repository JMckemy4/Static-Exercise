namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 68.0;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C");

            double newCelsius = 20.0;
            double newFahrenheit = TempConverter.CelsiusToFahrenheit(newCelsius);
            Console.WriteLine($"{newCelsius}°C is equivalent to {newFahrenheit}°F");


            //Now create a static class called TempConverter.
            //The class should have at least 2 methods, 
            //one called FahrenheitToCelsius that will require a double as a parameter and return a double,
            //the other CelsiusToFahrenheit which will also require a double as a parameter 
            //and return a double.
        }
    }
}
