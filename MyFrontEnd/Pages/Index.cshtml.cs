using Microsoft.AspNetCore.Mvc.RazorPages;
using Dapr.Client;
namespace MyFrontEnd.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly DaprClient _daprClient;
    public IndexModel(ILogger<IndexModel> logger , DaprClient daprClient)
    {
        _logger = logger;
        _daprClient=daprClient;
    }

    public async void OnGet()
    {
     var forecasts = await _daprClient.InvokeMethodAsync<IEnumerable<WeatherForecast>>(HttpMethod.Get,
                     "MyBackEnd", "weatherforecast");
     ViewData["WeatherForecastData"] = forecasts;

    }
}