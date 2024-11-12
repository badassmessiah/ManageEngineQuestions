using ManageEngineQuestions.Components;

namespace ManageEngineQuestions;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents().AddInteractiveServerComponents();

        builder.Services.AddHttpClient();

        if (!builder.Environment.IsDevelopment())
        {
            builder.WebHost.ConfigureKestrel(options => 
            {
                options.ListenLocalhost(5000, listenOptions => 
                {
                    listenOptions.UseHttps();
                });
            });
        }

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

        app.Run();
    }
}
