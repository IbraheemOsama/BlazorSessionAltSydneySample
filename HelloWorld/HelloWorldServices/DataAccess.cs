using System;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Blazor;

namespace HelloWorldServices
{
    public class DataAccess: IDataAccess
    {
        public HttpClient _client;
        public DataAccess(HttpClient client)
        {
            _client = client;
        }
        
        public Task<WeatherForecast[]> GetWeatherForecastsAsync()
        {
            return _client.GetJsonAsync<WeatherForecast[]>("/sample-data/weather.json");
        }
    }

    public interface IDataAccess
    {
        Task<WeatherForecast[]> GetWeatherForecastsAsync();
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
