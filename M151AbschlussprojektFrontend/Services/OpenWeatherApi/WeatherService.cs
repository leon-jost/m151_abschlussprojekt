using M151AbschlussprojektFrontend.Poco.OpenWeatherApi;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace M151AbschlussprojektFrontend.Services.OpenWeatherApi
{
    public class WeatherService : IWeatherService
    {
        HttpClient _httpClient;
        IConfiguration _configuration;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<HourlyForecast?> GetHourlyForecastAsync(double lat, double lon)
        {
            return await _httpClient.GetFromJsonAsync<HourlyForecast?>($"{_configuration["openWeatherApi:baseUrl"]}/onecall?lat={lat}&lon={lon}&exclude=current,minutely,daily,alerts&appid={_configuration["openWeatherApi:apiKey"]}&units=metric&lang=de");
        }
    }
}
