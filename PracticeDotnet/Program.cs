using PracticeDotnet.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<Student>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    System.Console.WriteLine("Middleware A Entering ....");
    await next();
    System.Console.WriteLine("Middleware A Exiting......");
});

app.Use(async (context, next) =>
{
    System.Console.WriteLine("Middleware B Entering ....");
    await next();
    System.Console.WriteLine("Middleware B Exiting......");
});

app.Use(async (context, next) =>
{
    System.Console.WriteLine("Middleware C Entering ....");
    await next();
    System.Console.WriteLine("Middleware C Exiting......");
});



app.UseRouting();
app.MapControllers();

app.Run();
