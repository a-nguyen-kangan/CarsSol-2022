using CarsLib;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Car c = new Car();

app.MapGet("/", () => "Hello World!");

app.Run();
