
namespace amicroservice.Models.Adapter
{
    public class ForecastAdaptee
    {
        public string GetTemperature(double value)
        {
            return $"{value}";
        }

    }
}