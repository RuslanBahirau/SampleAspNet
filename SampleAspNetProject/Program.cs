namespace SampleAspNetProject;

public class Program
{
    public static void Main()
    {
        var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

        host.Run();
    }
}
