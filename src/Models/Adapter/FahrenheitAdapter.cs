
namespace amicroservice.Models.Adapter
{
    public class FahrenheitAdapter : IForecastAdapter
    {
        private ForecastAdaptee _temeratureAdaptee = new ForecastAdaptee();
        public string GetTemperature(double inCelsius)
        {
            double inFahrenheit = (inCelsius * 1.8) + 32;
            string stringify = _temeratureAdaptee.GetTemperature(inFahrenheit);
            return $"{inCelsius} in Celsius is {stringify} in Fahrenheit";
        }
    }
}