using M151AbschlussprojektFrontend.Poco.OpenWeatherApi;

namespace M151AbschlussprojektFrontend.Services.OpenWeatherApi
{
    public interface IWeatherService
    {
        public Task<HourlyForecast?> GetHourlyForecastAsync(double lat, double lon);
    }
}
