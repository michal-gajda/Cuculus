namespace Cuculus.WebApi;

public static class Program
{
    const int EXIT_SUCCESS = 0;
    const string SERVICE_NAME = "Cuculus";

    public static async Task<int> Main(string[] args)
    {
        var webApplicationOptions = new WebApplicationOptions
        {
            ContentRootPath = AppContext.BaseDirectory,
            Args = args,
        };

        var builder = WebApplication.CreateBuilder(webApplicationOptions);

        builder.Host.UseWindowsService(options => options.ServiceName = SERVICE_NAME);

        builder.Services.AddHealthChecks();

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.UseHealthChecks("/health");

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseAuthorization();

        app.MapControllers();

        await app.RunAsync();

        return EXIT_SUCCESS;
    }
}

// dotnet build --configuration Release --use-current-runtime --self-contained --artifacts-path ./artifacts/

// sc.exe create ".NET Cuculus Service" binpath= "C:\Workspaces\DotNet9\Cuculus\artifacts\bin\Cuculus.WebApi\release\Cuculus.WebApi.exe"