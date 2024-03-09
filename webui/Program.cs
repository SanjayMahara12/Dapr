using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using webui.Data;
using Dapr.Client;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
var jsonOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
            };

//  var daprClient = new DaprClientBuilder()
//                 .UseJsonSerializationOptions(jsonOptions)
//                 .Build();

builder.Services.AddDaprClient(client=> {
client.UseJsonSerializationOptions(jsonOptions);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
