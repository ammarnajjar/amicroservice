using Microsoft.AspNetCore.Http;
using amicroservice.Models.Adapter;

namespace amicroservice.Services
{
    public class ForecastRepository
    {
        public string[] Temperature
        {
            get
            {
                IForecastAdapter degreeAdapter = new CelsiusAdapter();
                IForecastAdapter fahrenheitAdapter = new FahrenheitAdapter();

                return new string[] { degreeAdapter.GetTemperature(100.0), fahrenheitAdapter.GetTemperature(0.0) };
            }
        }
    }
}
