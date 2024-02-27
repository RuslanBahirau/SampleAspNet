namespace SampleAspNetProject;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IWebHostEnvironment hostingEnvironment)
    {
        var builder = new ConfigurationBuilder()
                        .SetBasePath(hostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                        .AddEnvironmentVariables();
        
        _configuration = builder.Build();
    }

    public void Configure(IApplicationBuilder appBuilder, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            appBuilder.UseDeveloperExceptionPage();
        }
        
        appBuilder.Run(async context => await context.Response.WriteAsync("Hello World!AAAAA"));
    }
}
