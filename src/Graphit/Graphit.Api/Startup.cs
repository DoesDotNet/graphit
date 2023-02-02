﻿namespace Graphit.Api;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        app.UseRouting();
        app.UseEndpoints(endpoints => {
            endpoints.MapGet("/", async context => {
                await context.Response.WriteAsync("Hello from new web Api");
            });
        });
    }
}