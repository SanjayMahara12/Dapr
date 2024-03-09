// See https://aka.ms/new-console-template for more information
using Dapr.Client;
using DaprCounter;
using System.Text.Json;
const string storeName="statestore";
const string key="counter";
//var daprClient = new DaprClientBuilder().Build();
//var counter = await daprClient.GetStateAsync<int>(storeName,key);
// while(true){
//     Console.WriteLine($"Counter = {counter++}");
//     await daprClient.SaveStateAsync(storeName,key,counter);
//     await Task.Delay(1000);
// }
//Console.WriteLine("Hello, World!");

 var jsonOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
            };

 var daprClient = new DaprClientBuilder()
                .UseJsonSerializationOptions(jsonOptions)
                .Build();



var forcastdata = await daprClient.InvokeMethodAsync<WeatherForecast[]>(HttpMethod.Get,"backend","weatherforecast");

Console.WriteLine(forcastdata.Length);
