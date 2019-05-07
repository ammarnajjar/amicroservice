
namespace amicroservice.Models.Adapter
{
    public class CelsiusAdapter : IForecastAdapter
    {
        private ForecastAdaptee _temeratureAdaptee = new ForecastAdaptee();
        public string GetTemperature(double inFahrenheit)
        {
            double inCelsius = (inFahrenheit - 32) * 5 / 9;
            string stringify = _temeratureAdaptee.GetTemperature(inCelsius);
            return $"{inFahrenheit} in Fahrenheit is {stringify} in Celsius";
        }
    }
}