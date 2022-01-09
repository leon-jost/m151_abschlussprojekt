using Blazored.LocalStorage;
using M151AbschlussprojektFrontend;
using M151AbschlussprojektFrontend.Services.OpenWeatherApi;
using M151AbschlussprojektFrontend.Services.TomTomApi;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<ITrafficIncidentService, TrafficIncidentService>();

await builder.Build().RunAsync();
