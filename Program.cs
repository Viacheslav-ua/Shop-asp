using Microsoft.AspNetCore;

namespace Shop_asp
{
    public class Program
    {
      public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //var builder = WebApplication.CreateBuilder(args);
            //var app = builder.Build();

            //app.MapGet("/", () => "Hello World APP!");

            //app.Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => 
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}