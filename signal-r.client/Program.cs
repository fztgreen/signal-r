using Microsoft.AspNetCore.SignalR.Client;


var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:7041/ChatHub")
    .Build();

connection.Closed += async (error) =>
{
    await Task.Delay(new Random().Next(0, 5) * 1000);
    await connection.StartAsync();
};

connection.On<string>("SendMessage", Console.WriteLine);

connection.StartAsync();

Console.WriteLine("Awaiting input...");
Console.ReadLine();