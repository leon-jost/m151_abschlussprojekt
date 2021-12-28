﻿using M151AbschlussprojektFrontend.Poco.OpenWeatherApi;
using M151AbschlussprojektFrontend.Services.OpenWeatherApi;
using M151AbschlussprojektFrontend.Services.TomTomApi;
using Microsoft.AspNetCore.Components;

namespace M151AbschlussprojektFrontend.Pages
{
    public partial class Home
    {
        [Inject]
        private IWeatherService WeatherService { get; set; }
        [Inject]
        private ITrafficIncidentService TrafficIncidentService { get; set; }

        private HourlyForecast? _hourlyForecast;
        private string _cleanOffCarMessage;

        private Traffic? _trafficIncidents;

        protected override async Task OnInitializedAsync()
        {
            // weather
            HourlyForecast? hourlyForecast = await WeatherService.GetHourlyForecastAsync(47.14237009806472, 8.636668156694977);

            double coldestTemp = 1;
            foreach (Hourly day in hourlyForecast.hourly)
            {
                // convert unix timestamp
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(day.dt).ToLocalTime();

                if (dateTime.Hour == 9)
                {
                    break;
                }
                else
                {
                    if (day.temp < coldestTemp)
                    {
                        coldestTemp = day.temp;
                    }
                }
            }

            if (coldestTemp <= 0)
            {
                _cleanOffCarMessage = $"Morgen muss das Auto gekratzt werden, denn es wird {coldestTemp} °C.";
            }
            else
            {
                _cleanOffCarMessage = "Morgen muss das Auto nicht gekratzt werden.";
            }

            // traffic incidents
            _trafficIncidents = await TrafficIncidentService.GetTrafficIncidentsAsync();
        }
    }
}